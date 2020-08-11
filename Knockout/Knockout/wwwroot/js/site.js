function WebmailViewModel() {
    var self = this;
    self.folders = ['Inbox', 'Archive', 'Sent', 'Spam'];
    self.chosenFolderId = ko.observable();
    self.chosenFolderData = ko.observable();
    self.chosenMailData = ko.observable();

    self.goToFolder = function (folder) {
        self.chosenFolderId(folder);
        self.chosenMailData(null);
        $.ajax({
            url: "/Home/Email",
            type: "GET",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                var emails = JSON.parse(response);
                var emailArray = [];

                for (var i = 0; i < emails.length; i++) {
                    if (emails[i].Folder == folder) {
                        emailArray.push({
                            id: emails[i].Id, folder: emails[i].Folder, from: emails[i].From,
                            to: emails[i].To, subject: emails[i].Subject, date: emails[i].Date,
                            message: emails[i].Message
                        });
                    }
                }

                self.chosenFolderData({ mails: emailArray });
            },
            failure: function (response) {
                alert(response);
            },
            error: function (response) {
                alert(response)
            }
        });
    };

    self.goToMail = function (mail) {
        self.chosenFolderId(mail.folder);
        self.chosenFolderData(null);
        $.ajax({
            url: "/Home/Email",
            type: "GET",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                var emails = JSON.parse(response);
                for (var i = 0; i < emails.length; i++) {
                    if (emails[i].Id == mail.id) {
                        self.chosenMailData({
                            from: emails[i].From, to: emails[i].To, subject: emails[i].Subject,
                            date: emails[i].Date, message: emails[i].Message
                        });
                    }
                }
            },
            failure: function (response) {
                alert(response);
            },
            error: function (response) {
                alert(response)
            }
        });
    };

    self.goToFolder('Inbox');
};

ko.applyBindings(new WebmailViewModel());
