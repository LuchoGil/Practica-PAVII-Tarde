
angular.module("myApp", []).controller("myCtrl", 
    function ($scope, $http) {

        $scope.lista = [];

        $http.get("/api/articulos").then(
            function (response) {
                $scope.lista = response.data;
            })
    })