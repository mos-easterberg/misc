var nodemailer = require('nodemailer');

var transporter = nodemailer.createTransport({
  service: 'gmail',
  auth: {
    user: 'magnus.osterberg@gmail.com',
    pass: ''
  }
});

var mailOptions = {
  from: 'magnus.osterberg@gmail.com',
  to: 'magnus_osterberg@hotmail.com',
  subject: 'Sending Email using Node.js',
  text: 'That was easy!'
};

transporter.sendMail(mailOptions, function(error, info){
  if (error) {
    console.log(error);
  } else {
    console.log('Email sent: ' + info.response);
  }
}); 