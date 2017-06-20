var app = angular.module("app", [])

app.controller("GestorClientesController", function ($scope, $http) {

    $scope.clientes = [];

    $http.get('/api/clientes').then(
        function (response) {
            debugger;
            $scope.clientes = response.data;
        })

})