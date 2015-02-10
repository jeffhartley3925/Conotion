angular.module('conotionApp').factory('enumService', function () {
	return {

		object:
		{
			"Clef": 0,
			"TimeSignature": 1,
			"Key": 2,
			"Bar": 3,
			"Accidental": 4,
			"Note": 5,
			"Rest" : 6
		},

		orientation:
	    {
	    	"Up": 0,
	    	"Down": 1
	    },

		timeSignature:
		{
			"4-4a": 4,
			"2-4": 1,
			"3-4": 2,
			"6-8": 0,
			"2-2a": 3,
			"2-2b": 5,
			"4-4b": 6
		},

		bar:
		{
			"Double": 0,
			"End": 1,
			"BeginRepeat": 2,
			"EndRepeat": 3,
			"BeginEndRepeat": 4,
			"Standard": 5,
			"None": 6,
			"StaffLeft": 7,
			"StaffRight": 8
		},

		clef:
		{
			"Treble": 0,
			"Bass": 1,
			"Alto": 2,
			"Tenor": 3
		},

		accidental:
		{
			"Sharp": 0,
			"Flat": 1,
			"Natural": 2
		},

		key:
		{
			"C": 0,
			"G": 1,
			"D": 2,
			"A": 3,
			"E": 4,
			"B": 5,
			"Gb": 6,
			"Db": 7,
			"Ab": 8,
			"Eb": 9,
			"Bb": 10,
			"F": 11,
			"Fs": 12,
			"Cs": 13
		},

		note:
		{
			"Whole": 0,
			"Half": 1,
			"Quarter": 2,
			"Eighth": 3,
			"Sixteenth": 4,
			"Thirtysecond": 5,
			"DottedWhole": 6,
			"DottedHalf": 7,
			"DottedQuarter": 8,
			"DottedEighth": 9,
			"DottedSixteenth": 10,
			"DottedThirtysecond": 11
		},

		rest:
		{
			"Whole": 0,
			"Half": 1,
			"Quarter": 2,
			"Eighth": 3,
			"Sixteenth": 4,
			"Thirtysecond": 5,
			"DottedWhole": 6,
			"DottedHalf": 7,
			"DottedQuarter": 8,
			"DottedEighth": 9,
			"DottedSixteenth": 10,
			"DottedThirtysecond": 11
		}
	};
});