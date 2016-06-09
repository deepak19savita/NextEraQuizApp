(function (scotchApp) {
    'use strict';
    scotchApp.controller('subjecteditController', function ($scope, $http) {
        $scope.subject = {};
        $scope.submitForm = function () {

            // check to make sure the form is completely valid
            if ($scope.subjectform.$valid) {
                if (angular.isDefined($scope.subject)) {
                    //$scope.subject.push({
                    //    "SubjectName": $scope.subject.SubjectName
                    //});
                   
                    UpdateMovieModel();
                    $scope.subject = [];
                }
            }

        };
        function post(url, data, success, failure) {
            return $http.post(url, data)
                    .then(function (result) {
                        success(result);
                    }, function (error) {
                        if (error.status == '401') {
                            notificationService.displayError('Authentication required.');
                            $rootScope.previousState = $location.path();
                            $location.path('/login');
                        }
                        else if (failure != null) {
                            failure(error);
                        }
                    });
        }
        function UpdateMovieModel() {
            $http.post('/api/subject', $scope.subject,
            updateMovieSucceded,
            updateMovieFailed);
        }

        function updateMovieSucceded(response) {
            console.log(response);
            notificationService.displaySuccess($scope.movie.Title + ' has been updated');
            $scope.movie = response.data;
            movieImage = null;
        }

        function updateMovieFailed(response) {
            notificationService.displayError(response);
        }
    });
})(angular.module('scotchApp'));