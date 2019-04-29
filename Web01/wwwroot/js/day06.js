////1.使用setTimeout()（不是setInterval()）实现每隔1秒钟依次显示：
////第n周，源栈同学random人。（n逐次递增，random随机）
////, 热烈庆祝源栈在'纽约证券交易'所上市
//var weeks = 0;
//function getRandom() {
//    weeks++;
//    var students = Math.floor(Math.random() * 99999);
//    if (weeks < weeks + 1) {
//        setTimeout(getRandom, 1000)
//        alert("第" + weeks + "周,源栈同学" + students + "人");
//    } else {
//        alert("一年啦");
//    }
//}
////setTimeout(getRandom, 1000);
//getRandom();

////2.完成猜数字的游戏：
////弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
////猜数字，范围可以在1~1000以内，

////浏览器生成一个不大于1000的随机正整数；
////用户输入猜测；
////如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
////只用了不到6次就猜到，弹出：碉堡了！
////只用了不到8次就猜到，弹出：666！
////用了8 - 10次猜到，弹出：猜到了。
////用了10次都还没猜对，弹出：^ (*￣(oo) ￣)^ 

//alert("尊敬的玩家,你好!请仔细阅读游戏规则!")
//alert("浏览器将随机生成一个1-1000的数字,请输入您的数字,直到猜中为止")
//var getRandom = Math.floor(Math.random() * 1000);
//var count = 0;
//while (1 === 1) {
//    var num = parseInt(prompt("请输入您的数字", ""));
//    if (count > = 10) {
//        alert("^ (*￣(oo) ￣)^");
//    }
//    count++;
//    if (count >  10) {
//        alert("^ (*￣(oo) ￣)^");
//    }
//    if (isNaN(num)) {
//        alert("请输入数字类型!");
//        continue;
//    }
//    if (num < 1 || num > 1000) {
//        alert("输入范围超过!");
//        continue;
//    }

//    if (num < getRandom) {
//        alert("小了");
//    } else if (num > getRandom) {
//        alert("大了");
//    } else {
//        if (count < 6) {
//            alert("碉堡了!");
//            break;
//        } else if (count < 8 && count >= 6) {
//            alert("666!");
//            break;
//        } else if (count < 10 && count >= 8) {
//            alert("猜到了!");
//            break;
//        }

//    }
//}

//设置闪烁颜色
var colors = ['white', 'black'];
//设置闪烁间隔
var frequency = 500;
//设置停止时间
var duration = 60000

var text = document.createElement('p');
text.innerHTML = '这里是测试文字';
document.body.innerHTML = ' ';
document.body.appendChild(text);

//设置循环间隔

var i = 0;
var timer = setInterval(function () {
    text.setAttribute('style', 'color:' + colors[i % colors.length]);

    //避免变量过大

    if (i++ > colors.length) i = 0;
}, frequency);
//设置停止时间
setTimeout(function () { clearInterval(timer) }, duration)
