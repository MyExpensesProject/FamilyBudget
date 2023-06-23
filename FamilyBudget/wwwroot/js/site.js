function AddSidebar(sidebarName, parameters, getDataFunction) {
    $('#openSidebar' + sidebarName).on("click", function () {
        $('#sidebar' + sidebarName).css("transform", "translateX(0)");
        $("#overlay").removeClass("hidden");
        if (getDataFunction != null && parameters != null) {
            getDataFunction(parameters);
        }
    });
    $('#closeSidebar' + sidebarName + ", " + "#overlay").on("click", function () {
        $('#sidebar' + sidebarName).css("transform", "translateX(-100%)");
        $("#overlay").addClass("hidden");
    });
}

function onTelegramAuth(user) {
    alert('Logged in as ' + user.first_name + ' ' + user.last_name + ' (' + user.id + (user.username ? ', @' + user.username : '') + ')');
}