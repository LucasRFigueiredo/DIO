// async/await

/*const asyncTimer = () =>
    new Promise((resolve, reject) => {
        setTimeout(() => {
            resolve(12345);
        }, 1000);
    });
const simpleFunc = async () => {
    const data = await Promise.all([
        asyncTimer(),
        fetch('/data.json').then(resStream => resStream.json())
    ]);
    return data;
};
simpleFunc()
.then(data => {
    console.log(data);
})
.catch(err => {
    console.log(err);
});*/

//EventEmitter
const EventEmitter = require('events');
class Users extends EventEmitter{
    userLogged(){
        this.emitter('User logged', data);
    }
}
const users = new Users();
users.on('User logged', data => {
    console.log(data);
});
users.userLogged({user: 'Lucas Figueiredo'});


