// * global EditPage variable
// * static object
// * wrapped in self-executing function so privates are private
window.EditPage = (function () {

    var $cblShippingOptions;

    function init(config) {
        $cblShippingOptions = $("#" + config.cblShippingOptionsId);
    }

    function validateShippingOptions(source, arguments) {
        arguments.IsValid = $cblShippingOptions.find("input:checked").length > 0;
    }   

    // public interface
    return {
        init: init,
        validateShippingOptions: validateShippingOptions
    }

}());