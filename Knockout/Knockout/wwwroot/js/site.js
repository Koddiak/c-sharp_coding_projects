function WebmailViewModel() {
    var self = this;
    self.folders = ['Inbox', 'Archive', 'Sent', 'Spam'];
    self.chosenFolderId = ko.observable();
    self.chosenFolderData = ko.observable();
    self.chosenMailData = ko.observable();

    self.goToFolder = function (folder) {
        self.chosenFolderId(folder);
        self.chosenMailData(null);
        $.get("/Home/Email", { folder: folder }, self.chosenFolderData);
    };

    self.goToMail = function (mail) {
        self.chosenFolderId(mail.folder);
        self.chosenFolderData(null);
        $.get("/Home/Email", { mailId: mail.id }, self.chosenMailData);
    };

    self.goToFolder('Inbox');
};

ko.applyBindings(new WebmailViewModel());
