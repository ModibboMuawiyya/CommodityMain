var btndic = {};
var formClonCount = 0;

function Load(url) {
    on();
    $('#home').load(url, function () {
        off();
        init_DataTables();
    });
}

$(window).load(function () {
    $('#mainBodyContent').click(function (e) {
        $('#sidebar').removeClass('active');
    });
});

$(function () {
    var toastmsg = $("#toastmsg").val();
    var toasterr = $("#toasterr").val();

    if (toasterr && toasterr !== '')
        toastr.error(toasterr);

    if (toastmsg && toastmsg !== '')
        toastr.info(toastmsg);

    $(document).ajaxError(function (event, jqxhr, settings, exception) {
        if (jqxhr.status === 401) {
            toastr.error("You are not authorized for this action");
        }
    });

    $('#datatable-buttons').DataTable({
        dom: 'Bfrtip',
        buttons: [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ],
        lengthMenu: [[10, 25, 50, -1], [10, 25, 50, "All"]],
        responsive: true
    });

    if ($('.datatable').length)
        $('.datatable').DataTable();

    if ($('#datatable-only').length) {
        $('#datatable-only').dataTable();

        if ($("#showTable").length) {
            $("#showTable").removeClass("d-none");
        }
    }


    $(document).on('click', '.removeCloned', function () {
        if (formClonCount == 1) {
            $(this).attr("disabled", true);
        } else {
            var id = $(this).data('removediv');
            $('#' + id).remove();
            formClonCount -= 1;
        }
    });

    $(document).on('click', '[data-toggle="tab"]', function (event) {
        event.preventDefault();
        var url = $(this).data('url');
        if (url != null && url != '') {
            Load(url);
        }
    });

    $(document).on('click', '.modalValidate', function (event) {
        on();
        var url = $(this).data('url');
        $.get(url).done(function (data) {
            off();
            placeholderElement.html(data);
            placeholderElement.find('.modal').modal('show');
        });

        $.validator.setDefaults({
            submitHandler: function (form) {
                var urlTarget = $(form).data('targeturl');
                var targetDiv = $(form).data('targetdiv');
                //alert(targetDiv);
                var actionUrl = $(form).attr('action');
                var dataToSend = new FormData($(form)[0]);
                $.ajax({
                    type: "POST",
                    url: actionUrl,
                    data: dataToSend,
                    processData: false,
                    contentType: false,
                    success: function (data) {
                        off();
                        if (data.status) {
                            placeholderElement.find('.modal').modal('hide');
                            toastr.success(data.msgX);
                            if (urlTarget != null && targetDiv == "innerTab") {
                                LoadInnerTab(urlTarget);
                            }
                            if (urlTarget != null && targetDiv != "innerTab") {
                                Load(urlTarget);
                            }
                        }
                        else {
                            placeholderElement.find('#msg').addClass('alert alert-danger').text(data.msg).show();
                            off();
                        }
                    }
                });
                off();
                return false;
            }
        });
        // custom validation for blob (images and select)

        $.validator.addMethod("mprequired", function (value, element) {
            if ((value > 0 && value !== null) || value.length > 0) {
                return value;
            }
        }, $.validator.messages.required)
    });

    $(document).on('click', '.modal-validate', function (event) {
        on();
        var url = $(this).data('url');
        $.get(url).done(function (data) {
            off();
            placeholderElement.html(data);
            placeholderElement.find('.modal').modal('show');
        });
    });

    $(document).on('click', '.raise-modal', function (event) {
        on();
        var url = $(this).data('url');
        $.get(url).done(function (data) {
            off();
            placeholderElement.html(data);
            placeholderElement.find('.modal').modal('show');
        });
    });



    // ------Button Action Loacder ---------------//
    $(document).on('click', '.process-action', function (event) {
        var txt = $(this).text().trim();
        //if (txt.toString() == 'Edit') {
        //    $(this).html('<i class="fa fa-spinner fa-spin"></i> Processing');

    });

    var placeholderElement = $('#modal-placeholder');
    var placeholderElement2 = $('#modal-placeholder2');

    $(document).on('click', '.smallModalId', function (event) {
        on();

        var url = $(this).data('url');
        $.get(url).done(function (data) {
            off();
            placeholderElement.html(data);
            placeholderElement.find('.modal').modal('show');
        });

    });

    $(document).on('click', '.returnModalV', function (event) {
        on();
        var url = $(this).data('url');
        $.get(url).done(function (data) {
            off();
            placeholderElement2.html(data);
            placeholderElement2.find('.modal').modal('show');
        });
    });

    $(document).on('click', '[data-save="submit-import"]', function (event) {
        event.preventDefault();
        var form = $('#regFormxx');
        var actionUrl = form.attr('action');
        var url = $(this).data('url');
        var dataToSend = new FormData($('#regFormxx')[0]);
        $.ajax({
            type: "POST",
            url: actionUrl,
            data: dataToSend,
            processData: false,
            contentType: false,
            success: function (data) {
                off();
                var newBody = $('.modal-body', data);
                //placeholderElement.find('.modal-body').replaceWith(newBody);
                var isValid = newBody.find('[name="IsValid"]').val() == 'True';
                if (data.status) {
                    placeholderElement.find('.modal').modal('hide');
                    toastr.success(data.msgX);
                    Load(url);
                }
                else {
                    toastr.error(data.msgX);
                }
            }
        });
    });

    $(document).on('click', '[data-save="submit-2-raise-modal"]', function (event) {
        event.preventDefault();
        var form = $('#regFormxx');
        var actionUrl = form.attr('action');
        var dataToSend = new FormData($('#regFormxx')[0]);
        var urlTarget = $(this).data('url2');
        $.ajax({
            type: "POST",
            url: actionUrl,
            data: dataToSend,
            processData: false,
            contentType: false,
            success: function (data) {
                var newBody = $('.modal-body', data);
                var isValid = newBody.find('[name="IsValid"]').val() == 'True';
                if (data.status) {
                    toastr.success(data.msgX);
                    if (urlTarget != "" && urlTarget != null) {
                        placeholderElement2.find('.modal').modal('hide');
                        $.get(urlTarget).done(function (data2) {
                            off();
                            placeholderElement.html(data2);
                            placeholderElement.find('.modal').modal('show');
                        });
                    }
                    else {
                        toastr.error(data.msgX);
                    }
                }
                else {
                    toastr.error(data.msgX);
                }
            }
        });
    });

    $(document).on('click', '[data-save="datajoe"]', function (event) {
        event.preventDefault();
        var cchhk = check_required_inputs();
        if (!cchhk) {
            //var placeholderElement = $('#modal-placeholder');
            var form = $('#regFormxx');
            var actionUrl = form.attr('action');
            var dataToSend = new FormData($('#regFormxx')[0]);
            var urlTarget = $(this).data('url');
            var targetDiv = $(this).data('targetdiv');
            //alert(urlTarget);
            $.ajax({
                type: "POST",
                url: actionUrl,
                data: dataToSend,
                processData: false,
                contentType: false,
                success: function (data) {
                    var newBody = $('.modal-body', data);
                    //placeholderElement.find('.modal-body').replaceWith(newBody);
                    var isValid = newBody.find('[name="IsValid"]').val() == 'True';
                    if (data.status) {
                        placeholderElement.find('.modal').modal('hide');
                        toastr.success(data.msgX);
                        if (urlTarget != null && targetDiv == "innerTab") {
                            LoadInnerTab(urlTarget);
                        }
                        if (urlTarget != null && targetDiv != "innerTab") {
                            Load(urlTarget);
                        }
                    }
                    else {
                        toastr.error(data.msgX);
                    }
                }
            });
        }
        else {
            toastr.error('Please fill all required fileds.');
            $('#requiredMsg').text('Please fill all required fileds.');
        }

    });

    $(document).on('click', '.removeItem', function (event) {
        let url = $(this).data('url');
        let name = $(this).data('name');
        swal({
            title: "",
            text: "Are you sure you want to remove " + name + " from requisition order?",
            icon: "warning",
            buttons: true,
            dangerMode: true
        }).then((willDelete) => {
            if (willDelete) {
                $.ajax({
                    type: "POST",
                    url: url,
                    success: function (data) {
                        let newBody = $('.modal-body', data);
                        placeholderElement.find('.modal-body').replaceWith(newBody);
                        toastr.success(name + ' removed from requisition order');
                    }
                });
            }
        });
    });

    $(document).on('click', '[data-toggle="pill"]', function (event) {
        event.preventDefault();
        var url = $(this).data('url');
        if (url != null && url != '') {
            LoadInnerTab(url);
        }
    });

    // Delete a cloned partial
    $(document).on('click', '.removeCloned', function () {
        if (formClonCount == 1) {
            $(this).attr("disabled", true);
            //$(this).removeClass("d-none");
            //$(this).addClass("d-none");
        } else {
            var id = $(this).data('removediv');
            $('#' + id).remove();
            formClonCount -= 1;
        }
    });

    //Cascade Dropdowns
    $(document).on('change', '[data-sel="cascade"]', function (event) {
        on();
        var Id = $(this).val();
        var url = $(this).attr('data-url') + Id;
        var to = $(this).attr('data-to');
        var loading = '<option value="" selected>Loading---</option>';
        $('#' + to).empty().append(loading);
        Cascade(url, to);
        off();
    });

    //Submit Form Via JavaScript

    $(document).on('click', '[data-save="data"]', function (event) {
        event.preventDefault();
        var placeholderElement = $('#modal-placeholder');
        var form = $('#regFormxx');
        var actionUrl = form.attr('action');
        var dataToSend = new FormData($('#regFormxx')[0]);
        var urlTarget = $(this).data('url');
        $.ajax({
            type: "POST",
            url: actionUrl,
            data: dataToSend,
            processData: false,
            contentType: false,
            success: function (data) {
                var newBody = $('.modal-body', data);
                //placeholderElement.find('.modal-body').replaceWith(newBody);
                var isValid = newBody.find('[name="IsValid"]').val() == 'True';
                if (isValid) {
                    placeholderElement.find('.modal').modal('hide');
                    toastr.success('Record added/updated successfully');
                    Load(urlTarget);
                }
                else {
                    alertErrorMeg('An error occured while processing the form!');
                }
            }
        });
    });

    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
    });
});

function Load(url) {
    on();
    //alert(url);
    $('#home').load(url, function () {
        off();
        //init_DataTables();
    });
}

function LoadContentToTargetedDiv(url, div, callback) {
    $('#' + div).load(url, function () {
        if (callback)
            callback();
    });
}

function InitializedDataTable(tableId, colNum) {
    if ($("#" + tableId).length) {
        $("#" + tableId).DataTable().destroy();
        $('#' + tableId).DataTable({
            columnDefs: [
                { orderable: false, targets: colNum }
            ],
            "order": []
        });
    }
}


function LoadForAll(url, targetID) {
    on();
    $('#' + targetID).load(url, function () {
        off();
    });
}

function LoadInnerTab(url) {
    on();
    $('#v-pills-home').load(url, function () {
        //process more logic
        off();
        //init_DataTables();
    });
}

//==============================================  Tab switch Script ============================//

function on() {
    document.getElementById("overlay").style.display = "block";
}

function off() {
    document.getElementById("overlay").style.display = "none";
}

function loadJDatePicker() {
    $('.jdatepicker').each(function () {
        //check if it has  jdatepicker-maxdate="1991-02-09"
        var maxDate = $(this).attr("jdatepicker-max") || "";
        var minDate = $(this).attr("jdatepicker-min") || "";
        var defaultDate = $(this).attr("jdatepicker-default") || "";

        var d = new Date();
        var date_year = d.getFullYear();
        // yearRange: '1950:2012' or yearRange: "-100:+0",

        var options = {
            dateFormat: 'dd-mm-yy', changeMonth: true, changeYear: true,  //showButtonPanel: true,
            //defaultDate: new Date(), maxDate: new Date(), // new Date('2018-3-26'),
            buttonImageOnly: true,
            yearRange: ('1960:' + date_year),
            beforeShow: function (input, inst) {
                $(".main-content-wrap").removeClass("hidecalender");
            }
        };
        if (maxDate.length > 6) { options.maxDate = new Date(maxDate); }
        if (minDate.length > 6) { options.minDate = new Date(minDate); }
        if (defaultDate.length > 7) { options.defaultDate = new Date(defaultDate); }

        $(this).datepicker(options);
    });

    $('.jdatemonthpicker').each(function () {
        var maxDate = $(this).attr("jdatepicker-max") || "";
        var minDate = $(this).attr("jdatepicker-min") || "";
        var defaultDate = $(this).attr("jdatepicker-default") || "";
        var updateOnChange = $(this).data("updateonchange") || "";
        var d = new Date();
        var date_year = d.getFullYear();

        var options = {
            dateFormat: "MM yy",
            changeMonth: true,
            changeYear: true,
            showButtonPanel: true,
            buttonImageOnly: true,
            yearRange: ('1960:' + date_year),
            onClose: function (dateText, inst) {
                function isDonePressed() {
                    return ($('#ui-datepicker-div').html().indexOf('ui-datepicker-close ui-state-default ui-priority-primary ui-corner-all ui-state-hover') > -1);
                }

                if (isDonePressed()) {
                    var month = $("#ui-datepicker-div .ui-datepicker-month :selected").val();
                    var year = $("#ui-datepicker-div .ui-datepicker-year :selected").val();
                    $(this).datepicker('setDate', new Date(year, month, 1)).trigger('change');

                    if (updateOnChange !== "") {
                        $("#" + updateOnChange).val($("#" + inst.id).val() + " Issue");
                    }

                    $('.date-picker').focusout();//Added to remove focus from datepicker input box on selecting date
                }
            },
            beforeShow: function (input, inst) {
                inst.dpDiv.addClass('month_year_datepicker');
                if ((datestr = $(this).val()).length > 0) {
                    year = datestr.substring(datestr.length - 4, datestr.length);
                    month = datestr.substring(0, 2);
                    $(this).datepicker('option', 'defaultDate', new Date(year, month - 1, 1));
                    $(this).datepicker('setDate', new Date(year, month - 1, 1));
                }
                $(".main-content-wrap").addClass("hidecalender");
            }
        };

        if (maxDate.length > 7) { options.maxDate = new Date(maxDate); }
        if (minDate.length > 7) { options.minDate = new Date(minDate); }
        if (defaultDate.length > 7) { options.defaultDate = new Date(defaultDate); }

        $(this).datepicker(options);
    });
}

function init_DataTables() {

    console.log('run_datatables');

    if (typeof ($.fn.DataTable) === 'undefined') { return; }
    console.log('init_DataTables');

    var handleDataTableButtons = function () {
        if ($("#datatable-buttons").length) {
            $("#datatable-buttons").DataTable({
                //dom: "Blfrtip",
                //buttons: [
                //    {
                //        extend: "copy",
                //        className: "btn-sm"
                //    },
                //    {
                //        extend: "csv",
                //        className: "btn-sm"
                //    },
                //    {
                //        extend: "excel",
                //        className: "btn-sm"
                //    },
                //    {
                //        extend: "pdfHtml5",
                //        className: "btn-sm"
                //    },
                //    {
                //        extend: "print",
                //        className: "btn-sm"
                //    },
                //],
                responsive: true
            });
        }
        if ($("#datatable-only").length) {
            $("#datatable-only").DataTable();
        }
    };
}
function ButtonLoading(button) {
    btndic[$(button).attr("id")] = $(button).html();
    var data_loading = $(button).attr("data-loading");
    if (data_loading == null || data_loading == "" || data_loading == "undefined") {
        data_loading = "";
    }

    data_loading = "<fa class='fa fa-spinner fa-pulse fa-fw'></fa> " + data_loading;
    $(button).attr("disabled", "disabled"); $(button).addClass("not-allowed");
    $(button).html(data_loading);

    $(button).closest("form").submit();
}

function ButtonRemoveLoading(button) {
    $(button).removeAttr("disabled").removeClass("not-allowed");
    $(button).html(btndic[$(button).attr("id")]);
}

function submitformdefault() {
    if ($("#savebtn").attr("disabled") == "disabled")
        return false;

    window.onbeforeunload = null;
    $('form').submit();
}

function confirmSubmit(url, uid, action, type, extra, callback) {
    //NOTE: added extra for the few cases i really want to use this method but need to pass more than one parameter
    Swal.fire({
        title: action + ' ' + type.split(' ')[0],
        text: 'Are you sure you want to ' + action + ' this ' + type + (type.indexOf(' ') > -1 ? '' : '?'),
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, ' + action + ' it'
    }).then((result) => {
        if (result.isConfirmed) {
            Swal.showLoading();

            $.ajax({
                type: 'POST',
                url: url,
                data: { uid, uid2: extra },
                success: function (result) {
                    Swal.hideLoading();

                    if (result.success) {
                        if (callback && typeof callback === "function") {
                            callback(result);
                        }
                        else
                            window.document.location.reload();
                    } else {
                        toastr.error(result.error);
                    }
                },
                error: function (data) {
                    toastr.error("Failed to " + action + " " + type + ". Please try again later");
                }
            });
        }
    });
}

function confirmFormSubmit(form, action, type) {
    //NOTE: added extra for the few cases i really want to use this method but need to pass more than one parameter
    Swal.fire({
        title: action + ' ' + type.split(' ')[0],
        text: 'Are you sure you want to ' + action + ' this ' + type + (type.indexOf(' ') > -1 ? '' : '?'),
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, ' + action + ' it'
    }).then((result) => {
        if (result.isConfirmed) {
            Swal.showLoading();

            $("#" + form).submit();
        }
    });
}

jQuery('.capitalize').text(function (index, currentText) {
    return currentText.toLowerCase();
}).css('text-transform', 'capitalize');

function slideToggle(toggle) {
    $("#" + toggle).slideToggle();
}

function advancedsearch(id) {
    if ($(".adv-search").length > 0) {
        $("#" + id).removeClass('d-none');
        $("#" + id).removeClass('adv-search');
    }
    else {
        $("#" + id).addClass('d-none');
        $("#" + id).addClass('adv-search');
    }

}
//Load a cloned Partial
function loadClonedForm(actionUrl) {
    $.ajax({
        type: "GET",
        url: actionUrl,
        processData: false,
        contentType: false,
        success: function (data) {
            var newBody = $('#ReturnData').append(data);
            formClonCount += 1;
        }
    });
}

function check_required_inputs() {
    var result = false;
    $('.required').each(function () {
        if ($(this).val() == "" || $(this).val() === '') {
            //$('#requiredMsg').text('Please fill all required fileds.');
            result = true;
        }
    });
    var emptyvalues = $('.selectmenu').filter(function () { return $(this).val() == '' }).length;
    alert(emptyvalues);
    if (emptyvalues) {
        //$('#requiredMsg').text('Please fill all required fileds.');
        result = true;
    }
    return result;
}

function alertErrorMeg(msg) {
    swal({
        title: "Error!",
        text: msg,
        icon: "warning",
        buttons: true,
        dangerMode: true
    });
}

function alertMegInfo(msg) {
    swal({
        title: "Information!",
        text: msg,
        icon: "success",
        buttons: true,
        dangerMode: true
    });
}

function NxtDelete(url, name, urlTarget) {
    swal({
        title: "Are you sure?",
        text: "You want to delete " + name + ", once deleted, you will not be able to recover",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "POST",
                url: url,
                success: function (data) {
                    if (data.status) {
                        toastr.success(data.msg);
                        if (urlTarget != null && urlTarget != '') {
                            Load(urlTarget);
                        }
                    }
                    else {
                        toastr.error(data.msg);
                    }
                }
            });
        }
    });
}

function RemoveItem(url, urlTarget, text, div) {
    swal({
        text: "Are you sure you want to remove " + text,
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "POST",
                url: url,
                success: function (data) {
                    if (data.status) {
                        toastr.success(data.msg);
                        if (urlTarget != null && div != '') {
                            LoadContentToTargetedDiv(urlTarget, div);
                        }
                    }
                    else {
                        toastr.error(data.msg);
                    }
                }
            });
        }
    });
}

function Delete(url, text) {
    swal({
        title: "Are you sure?",
        text: "You want to delete " + text + ", once deleted, you will not be able to recover",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "POST",
                url: url,
                success: function (data) {
                    if (data.status) {
                        toastr.success(data.message);
                        pageRefreshFunc();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}

function pageRefreshFunc() {
    setTimeout(
        function () {
            location.reload(false);
        },
        3000);
}

/**
 * this function cascades dropdown. It takes in id from where to decide cascading,
 * url to get data from and the id of the element to bind the data to.
 * param {any} from
 * param {any} url
 * param {any} bindTo
 */
function Cascade(url, bindTo) {
    $.ajax({
        url: url,
        success: function (data) {
            off();
            if (data.status == true) {
                var options = '<option value="" selected disabled>----SELECT----</option>';
                $.each(data.list, function (i, item) {
                    options = options + '<option value="' + item.id + '">' + item.name + '</option>';
                });
                $('#' + bindTo).empty().append(options);
            } else {
                var options = '<option value="" selected>----No records found----</option>';
                $('#' + bindTo).empty().append(options);
            }
        }
    });
}

function CascadeToMultiSelect(url, bindTo) {
    $.ajax({
        url: url,
        //data: JSON.stringify(paramArray),
        //contentType: 'application/json; charset=utf-8',
        //datatype: 'json',
        success: function (data) {
            off();
            if (data.status == true) {
                var options = '';
                var select = $('#' + bindTo);
                var selectedItems = $("#" + bindTo + " option:selected").map(function () {
                    return $(this).val();
                }).get();
                var selectedText = $("#" + bindTo + " option:selected").map(function () {
                    return $(this).text();
                }).get();

                $.each(data.list, function (i, item) {
                    var found = false;
                    for (var i = 0; i < selectedItems.length; i++) {
                        if (Number(selectedItems[i]) == item.id)
                            found = true;
                    }
                    if (!found) {
                        options = options + '<option value="' + item.id + '">' + item.name + '</option>';
                    }
                });
                for (var i = 0; i < selectedItems.length; i++) {
                    //Do something
                    options = options + '<option value="' + selectedItems[i] + '" selected="true">' + selectedText[i] + '</option>';
                }
                $('#' + bindTo).empty().append(options);
                $('#' + bindTo).multiSelect('refresh');
            } else {
                //var options = '<option value="" selected>----No selection made----</option>';
                //$('#' + bindTo).empty().append(options);
                $('#' + bindTo).multiSelect('refresh');
            }
        }
    });
}

function closeModal(item) {
    $(item).closest(".modal").modal('hide');
}

/**
 * This function previews an image base on what's given from the above 
 * onchange listener, it takes the image and the target preview container
 * param {any} file
 * param {any} target
 */
var ReadImage = function (file, target) {
    var reader = new FileReader;
    var image = new Image;
    reader.readAsDataURL(file);
    reader.onload = function (_file) {
        image.src = _file.target.result;
        image.onload = function () {
            $('#' + target).attr('src', _file.target.result);
        }
    }
}

function validateForm(cName) {
    // This function deals with validation of the form fields
    var x, y, z, i, isValid = true;
    x = document.getElementsByClassName(cName);
    y = x[0].getElementsByTagName("input");
    z = x[0].getElementsByTagName("select");

    // A loop that checks every input field in the current tab:
    for (i = 0; i < y.length; i++) {
        // If a field is empty...
        if (y[i].hasAttribute('required')) {
            if (y[i].value == "") {
                // add an "invalid" class to the field:
                //y[i].className += " invalid";
                // and set the current valid status to false
                isValid = false;
            }
        }
    }
    for (i = 0; i < z.length; i++) {
        // If a field is empty...
        if (z[i].hasAttribute('required')) {
            if (z[i].value == "") {
                // and set the current valid status to false
                isValid = false;
            }
        }
    }
    return isValid;

}

$(document).on('click', '[data-save="general"]', function (event) {
    event.preventDefault();
    var placeholderElement = $('#modal-placeholder');
    if (validateForm("tab")) {
        on();
        var form = $('#myForm');
        var actionUrl = form.attr('action');
        var dataToSend = new FormData($('#myForm')[0]);
        var urlTarget = $(this).data('targeturl');
        var targetDiv = $(this).data('targetdiv');
        var tableId = $(this).data('tableid');
        var nestableid = $(this).data('nestable');
        var colNum = $(this).data('col');
        $.ajax({
            type: "POST",
            url: actionUrl,
            data: dataToSend,
            processData: false,
            contentType: false,
            success: function (data) {
                if (data.status) {
                    placeholderElement.find('.modal').modal('hide');
                    toastr.success(data.msg);

                    if (targetDiv != null && urlTarget != null) {
                        LoadContentToTargetedDiv(urlTarget, targetDiv, InitializedDataTable(tableId, colNum));
                        off();
                    }
                    if (targetDiv == null && urlTarget != null) {
                        window.location.replace(urlTarget);
                    }

                    if (urlTarget != null && targetDiv != "innerTab") {
                        LoadForAll(urlTarget, targetDiv);
                        off();
                    }
                    if (nestableid != null) {
                        pageRefreshFunc();
                        //var updateOutput = function (e) {
                        //    var list = e.length ? e : $(e.target),
                        //        output = list.data('output');
                        //    if (window.JSON) {
                        //        output.val(window.JSON.stringify(list.nestable('serialize'))); //, null, 2));
                        //    } else {
                        //        output.val('JSON browser support required for this demo.');
                        //    }
                        //};
                        //updateOutput($('#' + nestableid).data('output', $('#nestable3-output')));
                        //$('#' + nestableid).nestable();
                    }
                }
                else {
                    off();
                    toastr.error(data.msg);
                }
            }
        });
    }
    else {
        toastr.error('Please fill all required fileds.');
    }

});


$(document).on('click', '[data-save="data"]', function (event) {
    event.preventDefault();
    var placeholderElement = $('#modal-placeholder');
    if (validateForm("tab")) {
        on();
        var form = $('#myFormXX');
        var actionUrl = form.attr('action');
        var dataToSend = new FormData($('#myFormXX')[0]);
        var urlTarget = $(this).data('targeturl');
        var targetDiv = $(this).data('targetdiv');
        var tableId = $(this).data('tableid');
        var nestableid = $(this).data('nestable');
        var colNum = $(this).data('col');
        $.ajax({
            type: "POST",
            url: actionUrl,
            data: dataToSend,
            processData: false,
            contentType: false,
            success: function (data) {
                if (data.status) {
                    placeholderElement.find('.modal').modal('hide');
                    toastr.success(data.msg);

                    if (targetDiv != null && urlTarget != null && tableId != null && colNum != null) {
                        LoadContentToTargetedDiv(urlTarget, targetDiv, InitializedDataTable(tableId, colNum));
                        off();
                    }
                    if (targetDiv == null && urlTarget != null) {
                        window.location.replace(urlTarget);
                    }

                    if (urlTarget != null && targetDiv != "innerTab") {
                        LoadForAll(urlTarget, targetDiv);
                        off();
                        //pageRefreshFunc();
                    }
                    if (nestableid != null) {
                        var updateOutput = function (e) {
                            var list = e.length ? e : $(e.target),
                                output = list.data('output');
                            if (window.JSON) {
                                output.val(window.JSON.stringify(list.nestable('serialize'))); //, null, 2));
                            } else {
                                output.val('JSON browser support required for this demo.');
                            }
                        };
                        updateOutput($('#' + nestableid).data('output', $('#nestable3-output')));
                        //$('#' + nestableid).nestable();
                    }
                }
                else {
                    off();
                    toastr.error(data.msg);
                }
            }
        });
    }
    else {
        toastr.error('Please fill all required fileds.');
    }
});

