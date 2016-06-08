(function (scotchApp) {
    'use strict';
    scotchApp.controller('subjectController', function ($scope, $http) {
        $scope.subjects = [];
        function loadSubject() {
            get('/api/subject', null,
            genresLoadCompleted,
            genresLoadFailed);
        }
        function genresLoadCompleted(response) {
            $scope.subjects = response.data;
        }

        function genresLoadFailed(response) {
            // notificationService.displayError(response.data);
            alert(response.data);
        }
        function get(url, config, success, failure) {
            return $http.get(url, config)
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
        loadSubject();
    });
})(angular.module('scotchApp'));