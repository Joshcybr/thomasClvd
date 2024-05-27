// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// script.js
<script>
    document.getElementById("registerLink").addEventListener("click", function () {
        document.getElementById("loginForm").style.display = "none";
    document.getElementById("registrationForm").style.display = "block";
        });
</script>