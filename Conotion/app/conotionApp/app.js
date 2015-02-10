var conotionApp = angular.module('conotionApp', ['ngRoute', 'ui.bootstrap', 'ngDraggable'])
.config(function ($routeProvider, $locationProvider) {
	var viewBase = '/app/conotionApp/views/';
	$routeProvider
	 .when('/', {
		templateUrl: viewBase + 'composition/home.html',
		controller: 'CompositionsCtrl'
     })
	 .when('/composition', {
	 	templateUrl: viewBase + 'composition/composition.html',
	 	controller: 'CompositionCtrl'
	 })
	 .when('/login/:redirect*?', {
        controller: 'LoginCtrl',
        templateUrl: viewBase + 'login.html'
     })
     .otherwise({ redirectTo: '/' });
});

angular.module('conotionApp.mouseCaptureService', []);
angular.module('conotionApp.draggingService', []);
angular.module('conotionApp.cacheService', []);
angular.module('conotionApp.controllers', []);
angular.module('conotionApp.directives', []);
angular.module('conotionApp.defaultService', []);
angular.module('conotionApp.enumService', []);
angular.module('conotionApp.vectorService', []);
