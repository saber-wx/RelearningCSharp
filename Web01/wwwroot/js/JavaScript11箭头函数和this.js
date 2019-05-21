//1.判断并证明事件处理函数中的this，等于target还是currentTarget
//2.已有如下代码：
//请用不同的方式调用fn()函数，能分别打印出‘飞哥’和‘老程’

var sname = "飞哥";
var a = {
    sname: '老程',
    fn: function () {
        console.log(this.sname);
    }
};
//a.fn();
//a.sname = sname;
//a.fn();

//var o = {};
//o.sname = sname;
//o.fn = a.fn;
//o.fn();

//3.不改变上述代码，分别使用call()和apply() ，打印出‘文轩’和‘两开花’
//a.fn.call(a,[a.sname = "两开花"]);
//a.fn.apply({ sname: "文轩" });

//4.将fn()永久拷贝到showName() ，始终打印‘源栈最棒！^ _ ^’

//let showName = a.fn.bind({ sname: "源栈最棒！^ _ ^" });
//showName();


//var fun1 = (x, y) => { console.log(x * y) };
//function fun2(x, y) { console.log(x * y) };



