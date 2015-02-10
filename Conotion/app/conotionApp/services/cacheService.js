angular.module('conotionApp').factory('cacheService', function () {

	var data = {
		compositionId: null
	};

	return {
		cache: function () {
			return data;
		},
		setId: function (id) {
			data.compositionId = id;
		},
		getData: function () {
			return data;
		},
	};
});