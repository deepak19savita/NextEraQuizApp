﻿
(function (scotchApp) {
    'use strict';
    scotchApp.controller('mainController', function ($scope) {
        // create a message to display in our view
        $scope.message = 'Everyone come and see how good I look!';
    });
})(angular.module('scotchApp'));