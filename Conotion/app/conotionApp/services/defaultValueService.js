angular.module('conotionApp').factory('defaultValueService', function () {
	return {
		compositionForeground: "#222222",
		compositionBackground: "#FFFFFF",

		provenanceFont: "Helvetica",

		staffgroupConfiguration: 1,
		staffAreaWidth: 150,

        measureWidth: 250,
        measureHeight: 150,
        measureLineSpacing: 8
    };
});