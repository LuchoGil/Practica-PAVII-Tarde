var app = angular.module("app", [])

app.controller("ArticulosController", function ($scope, $http) {
    $scope.articulos = [];

    $http.get('/api/articulos').then(
        function (response) { 
            debugger;
            $scope.articulos = response.data;
        }) 

})