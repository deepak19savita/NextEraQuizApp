(function () {
    'use strict';
    // create the module and name it scotchApp
    var scotchApp = angular.module('scotchApp', ['ngRoute']);

    // configure our routes
    scotchApp.config(function ($routeProvider) {
        $routeProvider
             
			// route for the home page
			.when('/', {
			    templateUrl: 'pages/home.html',
			    controller: 'mainController'
			})

			// route for the about page
			.when('/about', {
			    templateUrl: 'pages/about.html',
			    controller: 'aboutController'
			})
            // route for the question page
			.when('/question', {
			    templateUrl: 'pages/question/questionDetails.html',
			    controller: 'questionController'
			})
            .when('/subject', {
                templateUrl: 'pages/subject/subjectdetails.html',
                controller: 'subjectController'
            })
            .when('/subjectedit', {
                templateUrl: 'pages/subject/subjectedit.html',
                controller: 'subjecteditController'
            })
			// route for the contact page
			.when('/contact', {
			    templateUrl: 'pages/contact.html',
			    controller: 'contactController'
			});
    });    
})();
