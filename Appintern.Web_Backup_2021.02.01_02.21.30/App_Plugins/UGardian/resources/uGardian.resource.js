/**
 * Author r.tarik
 * Added on 24.05.2019
 */

(function () {
    'use strict';

    function uGardianResource($http, umbRequestHelper) {

        var resource = {
            getAllMembers: getAllMembers,
            getAllMembers1: getAllMembers1,
            getAllRoles: getAllRoles
        };

        var base = "/umbraco/backoffice/api/UGMembers/"
        
        return resource;

        //////////

        function getAllMembers() {
            return umbRequestHelper.resourcePromise(
                $http.get(base + "GetAllMembers"),
                "Failed to retrieve all members"
            );
        }

        function getAllMembers1() {
            return umbRequestHelper.resourcePromise(
                $http.get(base + "GetAllMembers1"),
                "Failed to retrieve all members"
            );
        }

        function getAllRoles() {
            return umbRequestHelper.resourcePromise(
                $http.get(base + "GetAllRoles"),
                "Failed to retrieve all roles"
            );
        }

    }

    angular.module('umbraco.resources').factory('uGardianResource', uGardianResource);

})();
