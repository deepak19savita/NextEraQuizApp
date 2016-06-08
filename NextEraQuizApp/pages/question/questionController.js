(function (scotchApp) {
    'use strict';
    scotchApp.controller('questionController', function ($scope) {
        $scope.message = 'Look! I am an question page.';
        $scope.isAddVisiable = false;
        $scope.isshow = function ()
        {
            if (!$scope.isAddVisiable)
                $scope.isAddVisiable = true;
            else
                $scope.isAddVisiable = false;
            return $scope.isAddVisiable;
        };
        $scope.books = [{
            name: 'The Book of Trees',
            price: 19,
            pubdate: new Date('2014', '03', '08'),
            likes: 0,
            dislikes: 0,
            email: 'deepak@abc.com'
        }, {
            name: 'Program or be Programmed',
            price: 8,
            pubdate: new Date('2013', '08',
              '01'),
            likes: 0,
            dislikes: 0,
            email: 'deepak@abc.com'
        }];

        $scope.Question = [{
            QuestionID: 1,
            Question: 'what is the name of the capital of india',
            Ans1: 'Delhi',
            Ans2: 'Mumbai',
            Ans6: 'Gujrat',
            Ans5: 'Kerala',
            Ans4: '',
            Ans3: '',
            Correct6: false,
            Correct5: false,
            Correct4: false,
            Correct3: false,
            Correct2: false,
            Correct1: false,
            Note: '',
            AnswerTye: 1,
            Marks: 12,
            Subject: 12,
            Course: 1
        }];


    });
})(angular.module('scotchApp'));