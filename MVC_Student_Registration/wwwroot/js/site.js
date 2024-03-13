// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const firstNameInput = document.querySelector('#student-first-name');
const lastNameInput = document.querySelector('#student-last-name');
const emailInput = document.querySelector('#student-email');
const courseName = document.querySelector('#course-name');
const courseStartDate = document.querySelector('#course-start-date');
const courseEndDate = document.querySelector('#course-end-date');

function ClearStudentFormInputs() {
    firstNameInput.value = '';
    lastNameInput.value = '';
    emailInput.value = '';
}

function ClearCourseFormInputs() {
    courseName.value = '';
    courseStartDate.value = '';
    courseEndDate.value = '';
}

$(document).ready(function () {
    $('#alert-success').hide();
    $('#alert-danger').hide();
});

function RegisterStudent() {
    // Prevent the default form submission behavior
    event.preventDefault();

    console.log('Registering Student...');

    var studentFormDataObject = {
        StudentFirstName: $('#student-first-name').val(),
        StudentLastName: $('#student-last-name').val(),
        StudentEmail: $('#student-email').val(),
    };

    $.ajax({
        url: '/Student/RegisterStudentController',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(studentFormDataObject),
        success: function (response) {
            if (response === 'success') {
                console.log('Student Registered Successfully!');

                ClearStudentFormInputs();

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

function RegisterCourse() {
    // Prevent the default form submission behavior
    event.preventDefault();

    console.log('Registering Course...');

    var courseFormDataObject = {
        CourseName: $('#course-name').val(),
        CourseStartDate: $('#course-start-date').val(),
        CourseEndDate: $('#course-end-date').val(),
    };

    $.ajax({
        url: '/Course/RegisterCourseController',
        type: 'POST',
        contentType: 'application/json',
        data: JSON.stringify(courseFormDataObject),
        success: function (response) {
            if (response === 'success') {
                console.log('Course Registered Successfully!');

                ClearCourseFormInputs();

                $('#alert-success').show();
                $('#alert-success').text('Course Registered Successfully!');
                $('#alert-danger').hide();
            } else {
                console.log('Course Registration Failed!');
                $('#alert-success').hide();
                $('#alert-danger').show();
                $('#alert-danger').text('Course Registration Failed!');
            }
        }
    });
}