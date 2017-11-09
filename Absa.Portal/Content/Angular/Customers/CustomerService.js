/// <reference path="../appmodule.js" />

App.factory('CustomerService', function ($http, $q, $window) {

    return {
        //Get Customer 
        GetCustomer: function () {
            return $http.get('/Customer/GetCustomer');
        },

        GetCustomerGuId: function () {
            var urlPath = $window.location.href;
            var result = String(urlPath).split("/");
            if (result != null && result.length > 0) {
                var id = result[result.length - 1];
                return id;
            }
        },

        //Update Customer Data. This function will call the controller's Update action method to Update the customer record.
        UpdateCustomerData: function (customerData) {
            var defer = $q.defer()
            
            $http({
                url: '/Customer/SaveCustomer',
                method: 'POST',
                data: customerData
            }).success(function (d) {
                defer.resolve(d);
                window.location.href = '/Home/Index';
            }).error(function (e) {
                alert("Error");
                defer.reject(e);
            });
            return defer.promise;
        },
    }
});