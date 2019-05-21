//1.使用setTimeout创建以下三个异步函数，分别使用普通callback方式和Promise方式，完成如下逻辑：
//1.1 getPassword(name) ：通过用户名获得他 / 她的密码
//1.2 login() ：如果密码正确，返回用户Id；否则，报一个异常
//1.3 getRecord() ：根据用户Id，返回该用户“打地鼠”游戏的最高记录
//1.4 捕获抛出的异常，输出（console.log）异常信息
//2.模拟Promise写一个MimicPromise类，能实现和Promise一样的功能（异步执行除外）

var wx = { name: "文轩", id: "233", password: "123456", maxRecord: "450" };

function getPassword(name) {
    setTimeout(() => {
        console.log(name.password)
    }, 1000);
};

getPassword(name);



//function login() {
//    if () {

//    }
//};

//function getRecord() {

//};

class MiniPromise {

    resolve() {
        if (true) {
            return this;
        }
    }
    reject() {
        if (false) {
            return this;
        }
    }
    then() {
       
    }
};