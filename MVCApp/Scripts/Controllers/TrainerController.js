(function () {
    angular.module("fuelApp").controller("trainerController", TrainerController);
    TrainerController.$inject = ["$scope", "trainerService"];

    function TrainerController($scope, trainerService) {
        var vm = this;

        vm.getAllTrainers = _getAllTrainers;

        vm.$onInit = _init;

        function _init() {
            console.log("trainerController connected...");
            vm.getAllTrainers();
        }

        function _getAllTrainers() {
            trainerService.GetAllTrainers()
                .then(function(data) {
                    console.log(data);
                })
                .catch(function(err) {
                    console.log(err);
                });
        }
    }
})();