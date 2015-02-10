angular.module('conotionApp').directive('conotionBar', function (defaultValueService, vectorService) {
	return {
		restrict: 'E',
		templateUrl: function (elem, attr) {
			return '../../app/conotionApp/templates/bars/bar-' + attr.barid + '-template.html';
		},
		replace: true,
		scope: {
			m: '=obj'
		},
		link: function (scope, element, attrs) {

			function mousedown(event) {
				alert(scope.m.measureId);
			}

			function mousemove(event) {

			}

			function mouseup(event) {

			}

			element.on('mousedown', mousedown);
			element.on('mousemove', mousemove);
			element.on('mouseup', mouseup);
		}
	};
});