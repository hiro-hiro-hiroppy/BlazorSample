window.jsFunctions = {
    alert: function (msg) {
        alert(msg);
    },
    confirm: function (msg) {
        return confirm(msg) == false ? 0 : 1;
    },
    changeTitle: function (title, id) {
        console.log("call jsFunctions.changeText");
        $(`#${id}`).text(title);
    },
    changeTitleRef: function (title, el) {
        console.log("call jsFunctions.changeTextRef");
        el.innerText = title;
    },
    commitTitle: function () {
        let title = $('#title').val();
        $('#msg').text(title);
        DotNet.invokeMethod(
            "BlazorJs", "commitTitleNet", title
        );
    }
}