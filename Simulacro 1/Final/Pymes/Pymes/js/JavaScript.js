var app = angular.module("app", [])

app.controller("DefaultController", function ($scope, $http) {
    $scope.articulos = [];

    $http.get('api/articulos').then(
        function (response) {
            debugger;
            $scope.articulos = response.data;
        })
})