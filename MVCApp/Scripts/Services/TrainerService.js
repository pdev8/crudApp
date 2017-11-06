(function () {
    angular.module("fuelApp").factory("trainerService", TrainerService);
    TrainerService.$inject = ["$http", "$q"];

    function TrainerService($http, $q) {
        //var apiRoot = "http://localhost:3024";

        var srv = {
            GetAllTrainers: _getAllTrainers
        };

        return srv;

        function _getAllTrainers() {
            return $http.get("/api/Trainers", { withCredentials: true })
                .then(function(response) {
                    return response.data;
                })
                .catch(function(error) {
                    return $q.reject(error);
                });
        }
    }
})();