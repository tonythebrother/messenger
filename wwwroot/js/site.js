

var app = new Vue({
    el: '#main',
    data: {
        search: '',
        chat: 'General Room',
        users: [],
        chatName: 'Messages',
        message: '',
        sender: '',
        receiver: 'Choose a chat',
        html: ''
    },
    firebase:{},
    created: function() {
        this.getUsers();
    },
    methods: {
        getUsers: function() {

            this.$http.get("https://localhost:5001/home/getusers").then(function(response) {
                this.users = response.body;
            });
        },
        openChatRoom: function(user, sender) {

            this.sender = sender;
            this.receiver = user;


            if (user === this.chat){

                this.chatName = "Messages";


            }else{

                let u = user.split("@"); 
                let s = sender.split("@");

                let chat = [u[0], s[0]];
                chat.sort();

                this.chatName = chat[0] + chat[1] + "Messages";

            }

            this.readMessages();
        },
        sendMessage: function(){

            if (message !== '') {

                let today = new Date();
                let minutesFormat = today.getMinutes() < 10 ? "0" + today.getMinutes() : today.getMinutes(); 
                let hour = today.getHours() + ":" + minutesFormat;

                firebase.database().ref(this.chatName).push().set({
                    "sender": this.sender,
                    "message": this.message,
                    "hour": hour
                });

                this.message = "";

                this.readMessages();
            }
                
        },
        readMessages: function() {

            this.html = "";

            document.getElementById("Chat").innerHTML = this.html;

            var sender = this.sender;
            var chatName = this.chatName;

                    firebase.database().ref(this.chatName).on("child_added", function (snapshot) {
    
                        this.html = (snapshot.val().sender !== sender) ? "<div class='message-response' id='message-" + snapshot.key + "'>" :
                            "<div class='message' id='message-" + snapshot.key + "'>";
                
                        if (snapshot.val().sender != sender) {

                            if (chatName == "Messages") {
                             
                            this.html += "<div class='sender'>";
                            this.html += snapshot.val().sender;
                            this.html += "</div>";

                            }
                
                        }
                
                        this.html += "<div class='text'>";
                        this.html += snapshot.val().message;
                        this.html += "</div>";
                        this.html += "<div class='time'>";
                        this.html += snapshot.val().hour;
                        this.html += "</div>";
                
                        if (snapshot.val().sender == sender) {
                            this.html += "<button data-id='" + snapshot.key + "' onclick='deleteMessage(this, "+ '"'+ chatName +'"' +")' class='btn btn-sm btn-danger btn-delete'> </button> ";
                        }
                
                        this.html += "</div>";
        
                        document.getElementById("Chat").innerHTML += this.html;
        
                    });            
        
        }
    },
    computed: {
        searchUser: function() {
            return this.users.filter((item) => item.email.includes(this.search.toLowerCase()));
        }
    }

});

function deleteMessage(self, chatName) {

    let messageID = self.getAttribute("data-id");
    
                firebase.database().ref(chatName).child(messageID).remove( function (error) {
                    if (error) {
                        alert("This message hasn't been removed. Check your internet connection.")
                    } else {
                        let html = "";
                        html += "<div class='text'>";
                        html += "This message has been removed.";
                        html += "</div>";
            
                        let messagedeleted = document.getElementById("message-" + messageID);
                        messagedeleted.innerHTML = html;
                    }
                });
            }