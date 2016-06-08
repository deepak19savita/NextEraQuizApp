(function (scotchApp) {
    'use strict';
    scotchApp.controller('aboutController', function ($scope) {
        $scope.message = 'Look! I am an about page.';
    });
})(angular.module('scotchApp'));