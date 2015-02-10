var comp = {

};

(function() {

	comp.vectors = null;
	comp.e = null;
	comp.defaults = null;

	comp.CompositionId = null;
	//
	// View model for a staffgroup.
	//
	comp.StaffgroupViewModel = function (model) {
		this.index = model.Index;
		this.sequence = model.Sequence;

		this.staves = createStavesViewModel(model.Staffs);
		this.height = this.staves.length * comp.defaults.measureHeight;
	};

	var createStaffgroupsViewModel = function (models) {
		var staffgroupsViewModel = [];

		if (models) {
			for (var i = 0; i < models.length; ++i) {
				staffgroupsViewModel.push(new comp.StaffgroupViewModel(models[i]));
			}
		}

		return staffgroupsViewModel;
	};

	//
	// View model for a staff.
	//
	comp.StaffViewModel = function (model) {

		this.staffId = model.StaffId;
		this.height = comp.defaults.measureHeight;
		this.width = comp.defaults.staffAreaWidth;;
		this.index = model.Index;
		this.sequence = model.Sequence;

		this.clefId = model.ClefType;
		this.keyId = model.KeyId;
		this.barId = model.Bar;
		this.timeSignatureId = model.TimeSignature;
		this.clefVector = comp.vectors.GetVector(comp.e.object.Clef, this.clefId);
		this.timeSignatureVector = comp.vectors.GetVector(comp.e.object.TimeSignature, this.timeSignatureId);
		this.keyVector = comp.vectors.GetVector(comp.e.object.Key, this.keyId);
		this.barVector = comp.vectors.GetVector(comp.e.object.Bar, this.barId);
		this.foreground = comp.defaults.compositionForeground;
		this.background = comp.defaults.compositionBackground;
		this.measures = createMeasuresViewModel(model.Measures, this.width);

	};

	var createStavesViewModel = function (models) {
		var stavesViewModel = [];

		if (models) {
			for (var i = 0; i < models.length; ++i) {
				stavesViewModel.push(new comp.StaffViewModel(models[i]));
			}
		}

		return stavesViewModel;
	};

	//
	// View model for a measure.
	//
	comp.MeasureViewModel = function (model) {

		this.measureId = model.MeasureId;
		this.keyId = model.KeyId;
		this.barId = model.Bar;
		this.timeSignatureId = model.TimeSignature;
		this.duration = model.Duration;

		this.width = model.Width;
		this.height = comp.defaults.measureHeight;
		this.index = model.Index;
		this.sequence = model.Sequence;
		this.foreground = comp.defaults.compositionForeground;
		this.background = comp.defaults.compositionBackground;

	};

	var createMeasuresViewModel = function (models, leftEdge) {
		var measuresViewModel = [];

		if (models) {
			for (var i = 0; i < models.length; ++i) {
				measuresViewModel.push(new comp.MeasureViewModel(models[i]));
			}
		}

		measuresViewModel.sort(function (a, b) {
			return a.sequence - b.sequence;
		});

		for (var j = 0; j < measuresViewModel.length; j++) {
			measuresViewModel[j].leftEdge = leftEdge;
			leftEdge += measuresViewModel[j].width;
		}
		return measuresViewModel;
	};

	//
	// View model for a composition.
	//
	comp.CompositionViewModel = function(model, vectors, enums, defaults) {

		comp.vectors = vectors;
		comp.e = enums;
		comp.defaults = defaults;

		this.scale = 1;
		this.angle = 0;
		this.keyId = model.KeyId;
		this.instrumentId = model.instrumentId;
		this.timeSignatureId = model.TimeSignature;
		this.staffConfiguration = model.StaffConfiguration;

		this.staffgroups = createStaffgroupsViewModel(model.Staffgroups);
		this.CompositionId = model.CompositionId;
	};


})();