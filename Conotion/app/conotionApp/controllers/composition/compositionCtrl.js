angular.module('conotionApp').controller('CompositionCtrl', ['$scope', '$http', '$routeParams', 'cacheService', 'defaultValueService', 'vectorService', 'enumService', function ($scope, $http, $routeParams, cacheService, defaultValueService, vectorService, enumService) {

	$scope.params = $routeParams;

	var selectedId = cacheService.getData().compositionId;

	if (selectedId != null && $scope.compositionId == null) {
		$http.get("/api/composition/getone/" + selectedId).success(function (data, status, headers, config) {

			$scope.compositionviewmodel = new comp.CompositionViewModel(data, vectorService, enumService, defaultValueService);

		}).error(function(data, status, headers, config) {
			$scope.error = "Oops... something went wrong with getlist query";
		});
	}

}]);