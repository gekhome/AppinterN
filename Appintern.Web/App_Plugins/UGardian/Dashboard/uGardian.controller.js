/**
 * Author r.tarik
 * Added on 24.05.2019
 */

var app = angular.module('umbraco.UGardian', []);
'use strict';
(function () {
    // Controller
    function UGardianController(memberResource, notificationsService, uGardianResource) {
        };

   app.controller('UGardianController', UGardianController);
})();
/* DATA TABLES */
function GetAdditionalMemberProperties(properties){
    var columns = [];
    properties.forEach(function (property, index) {
        var col = {};
        col.data = "properties." + index + "." + property.value ;
        col.title = property.alias;
        columns.push(col);
    });
  return columns;
}
var table = null;
function init_DataTables(members, memberResource) {
    if (typeof ($.fn.DataTable) === 'undefined') { return; }
  
    table = $('#datatable-responsive').DataTable({
        data: members,
        "processing": true,
        "language": {
            processing: '<i class="fa fa-spinner fa-spin fa-3x fa-fw"></i><span class="sr-only">Loading...</span> '
        },
        select: {
            style: 'multi'
        },
        "columnDefs": [
            {
                "targets": [0],
                "visible": false,
                "searchable": false
            }
           , {
                "targets": [1],
               "visible": false,
               "searchable": false
            }
            ],
        // columns: GetAdditionalMemberProperties(properties)
        columns: [
            { data: "Id", title: 'Id' },
            { data: "Key", title: 'Key' },
            { data: "Name", title: 'Name' },
            { data: "Email", title: 'Email' },
            { data: "Login", title: 'Login' },
            { data: "Type", title: 'Member Type' },
            { data: "Group", title: 'Member Group' },
            {
                data: "LastLogin", title: 'Last login', render: function (data, type, row, meta) {
                    return moment(data).format('YYYY-MM-DD HH:mm');
                }
            },
            {
                data: "CreatedOn", title: 'Created on', render: function (data, type, row, meta) {
                    return moment(data).format('YYYY-MM-DD HH:mm');
                }
            },
            {
                data: "UpdatedOn", title: 'Updated on', render: function (data, type, row, meta) {
                    return moment(data).format('YYYY-MM-DD HH:mm');
                }
            }
        ]
        ,
        dom: 'B<"lead">lfrtip',
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print', 'colvis'
        ]

        , "initComplete": function (settings, json) {
            $("#data-spinner").hide();
            var buttons = '<div class="btn-group" role="group" aria-label="...">' +
                '<button type="button" id="btn-delete-member" class="btn btn-danger">Delete</button>' +
            '</div>';
            $("#datatable-responsive_length label:first-child").after(buttons);
            $('#btn-delete-member').click(function () {
                var rowsData = table.rows({ selected: true }).data();
                var drawTable = true;
               $.each(rowsData, function () {
                   console.log($(this)[0].Key);
                    memberResource.deleteByKey($(this)[0].Key)
                        .then(function () {
                            console.log('Deleted member finished');
                        }, function (err) {
                                drawTable = false;
                            if (err.data && err.data.message) {
                                notificationsService.error(err.data.message);
                            }
                            else {
                                notificationsService.error('UGardian notification', 'An error occured while retrieving roles');
                            }
                            });
               });
                if (drawTable) {
                    table.rows('.selected').remove().draw(true);
                }
            });

        }
    });

    $('#datatable-responsive thead tr').clone(true).appendTo( '#datatable-responsive thead' );
    $('#datatable-responsive thead tr:eq(1) th').each( function (i) {
        var title = $(this).text();
        $(this).off('click');
        $(this).removeClass('sorting');
        $(this).removeClass('sorting_asc');
        $(this).removeClass('sorting_desc');
        $(this).html( '<input type="text" placeholder="Search" />' );
 
        $( 'input', this ).on( 'keyup change', function () {
            if ( table.column(i).search() !== this.value ) {
                table
                    .column(i)
                    .search( this.value )
                    .draw();
            }
        } );
    } );
    $('#datatable-responsive tbody')
        .on('mouseenter', 'td', function () {
            var colIdx = table.cell(this).index().column;

            $(table.cells().nodes()).removeClass('highlight');
            $(table.column(colIdx).nodes()).addClass('highlight');
        });


   

};
// Datatables
function GetGroupsButtons(groups){
    var buttons = [];
    groups.forEach(function (group, index) {
        var button = {};
        button.text = group ;
        button.action = function ( e, dt, node, config ) {
            // console.log(node);
            // console.log(config);
            var selectedGroup = config.text;
            var groupTag = 'Selected Group: <span class="label label-info">' + selectedGroup + '</span>';
            $('.buttons-collection').eq(1).children().first().html(groupTag);
            
           
            dt
            .column(6)
            .search( selectedGroup )
            .draw();
                    // alert( 'Activated!' );
                    
                    // this.disable(); // disable button
                };
        buttons.push(button);
    });
  return buttons;
}
function AddGroupsButtons(groups){
new $.fn.dataTable.Buttons(table, {
    buttons: [
        {
            extend: 'collection',
            collectionTitle: 'Filter members by group',
            dropup: true,
            text: 'Select Group',
            buttons: GetGroupsButtons(groups),
            autoClose: true
        }
    ]
});

    $("#datatable-responsive_length label:first-child").after(table.buttons(1, null).container());
    $("#datatable-responsive_length label:first-child").after("<span>   </span >");
    
   };

app.directive('datatableResponsive', ['memberResource', 'uGardianResource', function (memberResource, uGardianResource) {
   return {
       restrict: 'A',
       link: function(scope, element, attrs) {
           uGardianResource.getAllMembers1()
               .then(function (data) {
                   var members = data;
                   init_DataTables(members, memberResource);
                   uGardianResource.getAllRoles()
                       .then(function (groups) {
                           AddGroupsButtons(groups);
                       }, function (err) {
                           if (err.data && err.data.message) {
                               notificationsService.error(err.data.message);
                           }
                           else {
                               notificationsService.error('UGardian notification', 'An error occured while retrieving roles');
                           }
                       });

               }, function (err) {
                   if (err.data && err.data.message) {
                       notificationsService.error(err.data.message);
                   }
                   else {
                       notificationsService.error('UGardian notification', 'An error occured while retrieving members');
                   }
               }
           );
       }
   };
 }]);
var umb = angular.module("umbraco");
umb.requires.push('umbraco.UGardian');
