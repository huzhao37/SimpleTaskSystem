﻿var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('SimpleTaskSystem');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);