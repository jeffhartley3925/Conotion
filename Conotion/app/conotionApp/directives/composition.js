angular.module('conotionApp').directive('composition', function (defaultValueService, vectorService) {
	return {
		restrict: 'E',
		templateUrl: '../../app/conotionApp/templates/composition-template.html',
		scope: { compositionviewmodel: '=' },
		link: function (scope, element, attrs) {

			function mousedown(event) {
				alert("composition");
			}

			element.on('mousedown', mousedown);
		}
	};
});