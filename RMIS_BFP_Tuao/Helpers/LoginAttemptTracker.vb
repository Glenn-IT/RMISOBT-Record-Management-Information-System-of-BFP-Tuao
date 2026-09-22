Namespace Helpers

    Public Class LoginAttemptTracker

        Public Const MaxAttempts As Integer = 3
        Public Const LockoutDurationSeconds As Integer = 15

        Private Shared ReadOnly _syncRoot As New Object()
        Private Shared ReadOnly _failedAttempts As New Dictionary(Of String, Integer)(StringComparer.OrdinalIgnoreCase)
        Private Shared ReadOnly _lockedUntil As New Dictionary(Of String, DateTime)(StringComparer.OrdinalIgnoreCase)

        ''' <summary>
        ''' Records a failed login attempt for the given username.
        ''' If max attempts reached, sets a lockout duration and returns IsLockedOut = True.
        ''' </summary>
        Public Shared Function RecordFailedAttempt(username As String) As (IsLockedOut As Boolean, RemainingAttempts As Integer, LockoutSeconds As Integer)
            If String.IsNullOrWhiteSpace(username) Then
                Return (False, MaxAttempts, 0)
            End If

            Dim key = username.Trim()

            SyncLock _syncRoot
                If Not _failedAttempts.ContainsKey(key) Then
                    _failedAttempts(key) = 0
                End If
                _failedAttempts(key) += 1

                If _failedAttempts(key) >= MaxAttempts Then
                    _lockedUntil(key) = DateTime.Now.AddSeconds(LockoutDurationSeconds)
                    _failedAttempts.Remove(key)
                    Return (True, 0, LockoutDurationSeconds)
                Else
                    Dim remaining = MaxAttempts - _failedAttempts(key)
                    Return (False, remaining, 0)
                End If
            End SyncLock
        End Function

        ''' <summary>
        ''' Checks if the given username is currently locked out.
        ''' Automatically cleans up expired lockouts.
        ''' </summary>
        Public Shared Function CheckLockout(username As String) As (IsLockedOut As Boolean, RemainingSeconds As Integer)
            If String.IsNullOrWhiteSpace(username) Then
                Return (False, 0)
            End If

            Dim key = username.Trim()

            SyncLock _syncRoot
                If Not _lockedUntil.ContainsKey(key) Then
                    Return (False, 0)
                End If

                Dim remaining = CInt(Math.Ceiling((_lockedUntil(key) - DateTime.Now).TotalSeconds))
                If remaining > 0 Then
                    Return (True, remaining)
                End If

                ' Lockout has expired — clean up
                _lockedUntil.Remove(key)
                _failedAttempts.Remove(key)
                Return (False, 0)
            End SyncLock
        End Function

        ''' <summary>
        ''' Resets failed attempts and lockout state for a specific user (e.g. on successful login).
        ''' </summary>
        Public Shared Sub Reset(username As String)
            If String.IsNullOrWhiteSpace(username) Then Return
            Dim key = username.Trim()
            SyncLock _syncRoot
                _failedAttempts.Remove(key)
                _lockedUntil.Remove(key)
            End SyncLock
        End Sub

        ''' <summary>
        ''' Clears all failed attempts and lockouts across all users (useful for tests).
        ''' </summary>
        Public Shared Sub ClearAll()
            SyncLock _syncRoot
                _failedAttempts.Clear()
                _lockedUntil.Clear()
            End SyncLock
        End Sub

    End Class

End Namespace
