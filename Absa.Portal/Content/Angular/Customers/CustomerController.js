/// <reference path="../appmodule.js" />

App.controller('CustomerController', function ($scope, $filter, CustomerService) {

    $scope.isFormValid = false;
    $scope.message = null;
    $scope.Customer = null;
    $scope.canEdit = false;
    $scope.IdentityTypes = [
        { id: 0, name: 'Passport' },
        { id: 1, name: 'Identity Document' }        
    ];

    CustomerService.GetCustomer().then(function (d) {
        var birthDate = d.data["DateOfBirth"];
        d.data["DateOfBirth"] = $filter('date')(birthDate, "yyyy-MM-dd");
        $scope.customer = d.data;
    });

    // customer Object
    $scope.Customer = {
        FirstNames: '',
        Surname: '',
        DateOfBirth: '',
        IdentityNumber: '',
        IdentityType: ''
    };

    //check form validation
    $scope.$watch('CreateForm.$valid', function (newValue) {
        $scope.isFormValid = newValue;
    });

    //Update Customer Data function
    $scope.UpdateCustomer = function () {

        var Customer = {
            FirstNames: $scope.FirstNames,
            Surname: $scope.Surname,
            DateOfBirth: $scope.DateOfBirth,
            IdentityNumber: $scope.IdentityNumber,
            IdentityType: $scope.IdentityType,
            Guid: uuidv4(),
        };
        
        CustomerService.UpdateCustomerData(Customer);
        $scope.canEdit = false;
    }

    //Redrect index form to edit form.
    $scope.RedirectToDetails = function (guid) {
        $scope.canEdit = false;
        window.location.href = '/Home/Index/' + guid;
    };
    
    $scope.EditCustomer = function (customer) {

        var getData = CustomerService.GetCustomer();

        getData.then(function (cust) {
            $scope.customer = cust.data;
            $scope.FirstNames = customer.FirstNames;
            $scope.Surname = customer.Surname;
            $scope.DateOfBirth = customer.DateOfBirth;
            $scope.IdentityNumber = customer.IdentityNumber;
            $scope.IdentityType = customer.IdentityType;
            $scope.NewGuid = uuidv4();
            $scope.Action = "Update";
            $scope.canEdit = true;
        },
            function () {
                alert('Error in getting records');
            });          
    }

    function uuidv4() {
        return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
            var r = Math.random() * 16 | 0, v = c == 'x' ? r : (r & 0x3 | 0x8);
            return v.toString(16);
        });
    };

    //Clear Form Function
    function ClearForm() {
        $scope.Customer = {};
        $scope.CreateForm.$setPristine();
        $scope.UpdateCustomer = {};
        $scope.EditForm.$setPristine();
        $scope.App.NewGuid = {};
    }
});

