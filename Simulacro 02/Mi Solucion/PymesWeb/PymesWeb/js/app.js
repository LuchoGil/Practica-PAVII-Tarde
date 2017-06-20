
angular.module("myApp", []).controller("clientesController",
    function ($scope, $http) {

        $http.get("/api/Clientes").then(
            function (response) {
                $scope.lista = response.data;

            });

    });