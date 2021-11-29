(function () {
    'use strict';

    angular.module('appMain', ['ngSanitize']);

    angular
        .module('appMain')
        .factory('appOperation', appOperation);

    appOperation.$inject = ['$http'];

    function appOperation($http) {
        var service = {
            getData: getData
        };

        return service;

        function getData(method, url, data = null) {
            var dataService = $http({
                method: method, url: url, data: data, headers: {'Content-Type': 'application/json' }
            }).then(function (response) { return response.data });
            return dataService
        };
    }
})();
