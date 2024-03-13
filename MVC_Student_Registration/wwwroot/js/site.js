// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const firstNameInput = document.querySelector('#student-first-name');
const lastNameInput = document.querySelector('#student-last-name');
const emailInput = document.querySelector('#student-email');

function ClearInputs() {
    firstNameInput.value = '';
    lastNameInput.value = '';
    emailInput.value = '';
}

$(document).ready(function () {
    $('#alert-success').hide();
    $('#alert-danger').hide();
});

function RegisterStudent() {
    // Prevent the default form submission behavior
    event.preventDefault();

    console.log('Registering Student...');

    var studentObject = {
        StudentFirstName: $('#student-first-name').val(),
        StudentLastName: $('#student-last-name').val(),
        StudentEmail: $('#student-email').val(),
    };

    $.ajax({
        url: '/Student/RegisterStudentController',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(studentObject),
        success: function (response) {
            if (response === 'success') {
                console.log('Student Registered Successfully!');

                ClearInputs();

                $('#alert-success').show();
                $('#alert-success').text('Student Registered Successfully!');
                $('#alert-danger').hide();
            } else {
                console.log('Student Registration Failed!');
                $('#alert-success').hide();
                $('#alert-danger').show();
                $('#alert-danger').text('Student Registration Failed!');
            }
        }
    });
}