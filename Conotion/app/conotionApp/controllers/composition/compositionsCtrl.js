/// <reference path="compositionsCtrl.js" />
angular.module('conotionApp').controller('CompositionsCtrl', ['$scope', '$http', '$routeParams', 'cacheService', '$location', function ($scope, $http, $routeParams, cacheService, $location) {

    $scope.controllerName = "Compositions Controller";
	$scope.params = $routeParams;
	$scope.message = "";
    $scope.error = "";

    $scope.roots = null;

	$http.get("/api/composition/getlist/9337AEEB-F1B0-4DA6-8ACF-1E9D95303808").success(function (data, status, headers, config) {
        $scope.roots = data;
    }).error(function (data, status, headers, config) {
        $scope.error = "Oops... something went wrong with getlist query";
    });

    $scope.edit = function (id) {
    	cacheService.setId(id);
	    $location.path("/composition");
    };

    $scope.oneAtATime = true;

    $scope.status = {
		open: false,
    	isFirstOpen: true,
    	isFirstDisabled: false
    };
}]);