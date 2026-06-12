// ============================================================
//  SPARK - AuthService.cs
//  Login, logout, dan password hashing
//  Pasang package: Install-Package BCrypt.Net-Next
// ============================================================

using System;
using BCrypt.Net;
using FINAL_PROJECT.forms.Repositories;
using FINAL_PROJECT.Models;

namespace FINAL_PROJECT.services
{
    public class AuthService
    {
        private readonly UserRepository _userRepo = new();

        // ── Login ─────────────────────────────────────────────
        /// <summary>
        /// Cek username + password, return User jika valid.
        /// Return null jika gagal.
        /// </summary>
        public User? Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
                return null;

            var user = _userRepo.FindByUsername(username);
            if (user == null) return null;

            bool passwordValid = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
            return passwordValid ? user : null;
        }

        // ── Hash password (pakai saat buat user baru) ─────────
        public string HashPassword(string plainPassword) =>
            BCrypt.Net.BCrypt.HashPassword(plainPassword, workFactor: 12);

        // ── Cek role ──────────────────────────────────────────
        public bool IsAdmin(User user)   => user.Role == RoleUser.Admin;
        public bool IsManager(User user) => user.Role == RoleUser.Manager;
        public bool IsPetugas(User user) => user.Role == RoleUser.Petugas;
    }

    // ============================================================
    //  CONTOH PENGGUNAAN DI FORM LOGIN (Windows Forms)
    // ============================================================

    /*
    // Di FormLogin.cs:
    
    private readonly AuthService _authService = new AuthService();
    private User? _currentUser;

    private void btnLogin_Click(object sender, EventArgs e)
    {
        var user = _authService.Login(txtUsername.Text, txtPassword.Text);
        
        if (user == null)
        {
            MessageBox.Show("Username atau password salah!", "Login Gagal",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _currentUser = user;
        
        // Buka form sesuai role (polymorphism)
        Form nextForm = user switch
        {
            Admin   => new FormAdmin(user),
            Manager => new FormManager(user),
            Petugas => new FormPetugas(user),
            _       => throw new InvalidOperationException("Role tidak dikenal")
        };

        this.Hide();
        nextForm.ShowDialog();
        this.Show();
    }
    */

}
