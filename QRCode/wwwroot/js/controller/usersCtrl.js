(function () {
    'use strict';

    angular
        .module('appMain')
        .controller('usersCtrl', usersCtrl);

    usersCtrl.$inject = ['$scope', 'appOperation'];

    function usersCtrl($scope, aO) {

        $scope.usersList = function () {
            aO.getData('GET', '/Home/UserGetAll').then(function (response) {
                if (response.code === "0") {
                    console.log(response.message);
                } else if (response.code === "1") {
                    $scope.users = response.payload;
                }
            }).catch(function (error) {
                console.log(error);
            });
        }
        $scope.usersList();

    }
})(window.angular);
