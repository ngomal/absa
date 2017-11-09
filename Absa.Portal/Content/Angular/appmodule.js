var App;

(function () {
    App = angular.module("customerApp", ['ngRoute']);

    App.filter("dateFilter", function () {
        return function (item) {
            if (item != null) {
                return new Date(parseInt(item.substr(6)));
            }
            return "";
        };
    });

    App.filter('dateFormat', function ($filter) {
        return function (input) {
            if (input == null) { return ""; }

            var _date = $filter('date')(new Date(input), 'MMM dd yyyy');

            return _date.toUpperCase();

        };
    });

    })();
