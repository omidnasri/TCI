/**
 * 
 * @returns {} 
 */
function partial_section() { return "#sectionContents"; }

/**
 * 
 * @returns {} 
 */
function closeDialog() {
    $(partial_section()).empty();
}

/**
 * 
 * @param {} data 
 * @returns {} 
 */
function InsertDialog(data) {
    var h = "<div class='modal fade in' id='portlet-form' tabindex='-1' role='dialog' aria-labelledby='myModalLabel' aria-hidden='false' style='display: block;'>";
    h += "<div class='modal-backdrop fade in'></div><div class='modal-dialog'><div class='modal-content'><div class='modal-header'><button type='button' class='close' data-dismiss='modal' aria-hidden='true' onclick='$(\"#portlet-form\").hide();'></button>";
    h += "<h4 class='modal-title'>Title</h4></div><div class='modal-body' style='max-height:450px;overflow-y:auto'>";
    h += data;
    h += "</div><div class='modal-footer'><input onclick='$(\"#btnSave\").click();' type='submit' value=\"Submit\" class='btn btn-default'/><button type='button' onclick='$(\"#portlet-form\").hide();' class='btn btn-default' data-dismiss='modal'><i class=\"fa fa-close\"></i> Close</button></div></div></div></div>";
    $("#sectionContents").html(h);
}

$("[load-partial]").live("click", function () {
    var html = $(partial_section()).load($(this).attr("load-partial"), function() {
        InsertDialog(html.html());
    });
});
/**
 * Status Code
 */
var httpStatusCode = { Remove_Success: 151, Remove_Failed: 152, Input_Invalid: 153, Created_Page: 154, Enable_Status: 155, Disable_Status: 156, Redirect_To_Page: 157, Login_Failed: 159, Login_Success: 160, LockedOut: 161, Forgot_Password_Confirmation: 162 };
function SuccessModel(data) {
    if (data.StatusCode === httpStatusCode.Created_Page)
    {
        showMessage('', initializeculture.Authorize_Has_Been_Successfully, "success");
    }
    closeDialog();
}
/**
 * 
 * @param {} head 
 * @param {} body 
 * @param {} theme 
 * @returns {} 
 */
function showMessage(head, body, theme) {
    toastr.options = {
        "closeButton": true,
        "debug": false,
        "progressBar": true,
        "positionClass": "toast-bottom-full-width",
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }
    if (theme === "success")
        toastr.success(body, head);
    if (theme === "error")
        toastr.error(body, head);
    if (theme === "warning")
        toastr.warning(body, head);
    if (theme === "info")
        toastr.info(body, head);
}