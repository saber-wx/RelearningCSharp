
//将现在时间打印在网页上
var today = new Date();
function nowTime() {
    var currentlyYear = today.getFullYear();
    var currentlyMonth = today.getMonth() + 1;
    var currentlyDay = today.getDate();
    document.getElementById('now-time').innerHTML = currentlyYear + "年" + currentlyMonth + "月" + currentlyDay + "日";
}

////输入几周可获得截至时间
//function overTime() {
//    var overDateTime = today.getTime() + parseInt(document.getElementsByName("week-amount")[0].value) * 7 * 24 * 60 * 60 * 1000;
//    var overDate = new Date(overDateTime);
//    var overYear = overDate.getFullYear();
//    var overlyMonth = overDate.getMonth() + 1;
//    var overDay = overDate.getDate();
//    document.getElementById("over-time")(`课程一共${parseInt(document.getElementsByName("week-amount")[0].value)}周,截至到${overYear}年${overlyMonth}月${overDay}日,学费${parseInt(document.getElementsByName("week-amount")[0].value) * 986}元`);

//}

////开始日期的时间戳
////new Date(document.getElementById('start-time').value).getTime()
//////结束日期的时间戳
////new Date(document.getElementById('end-time').value).getTime()
////时间戳相差多少
////(new Date(document.getElementById('end-time').value).getTime()) - (new Date(document.getElementById('start-time').value).getTime())
////学习多少天
//var weekTime = 7 * 24 * 60 * 60 * 1000,
//    dayTime = 24 * 60 * 60 * 1000;

////1.选择了课程结束日期的
//document.getElementsByName("confirm-time")[0].onclick = function () {
//    var days = ((new Date(document.getElementById('end-time').value).getTime()) - (new Date(document.getElementById('start-time').value).getTime())) / dayTime;
//    //学习周数
//    var weekNumber = Math.floor(days / 7),
//        weekResidue = days % 7;
//    document.getElementById("over-time").innerHTML = "课程一共" + weekNumber + "周零" + weekResidue + "天,学费" + (Math.floor(days * 986 / 7)) + "元";
//}

////2.输入了月数的(未实现)
////获取输入的月数
//parseInt(document.getElementsByName("month-amount")[0].value);
////获得开始的月数
//parseInt(new Date(document.getElementById('start-time').value).getMonth() + 1);
////获得开始是哪一天
//parseInt(new Date(document.getElementById('start-time').value).getDate());
////获得结束的月份

////3.输入了周数的
//document.getElementsByName("confirm-week")[0].onclick = function () {
//    //获取输入的周数
//    //parseInt(document.getElementsByName("week-amount")[0].value);
//    //算出是多少天的时间戳
//    //(parseInt(document.getElementsByName("week-amount")[0].value) * 7 * 24 * 60 * 60 * 1000);
//    //获得开始是哪一天的时间戳 加上多少天的时间戳
//    //new Date((parseInt(new Date(document.getElementById('start-time').value).getTime())) + (parseInt(document.getElementsByName("week-amount")[0].value) * 7 * 24 * 60 * 60 * 1000);
//    //获取结束年份
//    var weekYear = (new Date((parseInt(new Date(document.getElementById('start-time').value).getTime())) + ((parseInt(document.getElementsByName("week-amount")[0].value)) * 7 * 24 * 60 * 60 * 1000))).getFullYear();
//    //获取结束月份
//    var weekMonth = (new Date((parseInt(new Date(document.getElementById('start-time').value).getTime())) + ((parseInt(document.getElementsByName("week-amount")[0].value)) * 7 * 24 * 60 * 60 * 1000))).getMonth();
//    //获取结束日期
//    var weekDay = (new Date((parseInt(new Date(document.getElementById('start-time').value).getTime())) + ((parseInt(document.getElementsByName("week-amount")[0].value)) * 7 * 24 * 60 * 60 * 1000))).getDate();

//    document.getElementById("over-week").innerHTML = "课程截止到" + weekYear + "年" + weekMonth + "月" + weekDay + "日,一共" + parseInt(document.getElementsByName("week-amount")[0].value) + "周, 学费:" + parseInt(document.getElementsByName("week-amount")[0].value * 986) + "元";
//}


////4.输入了天数的
//document.getElementsByName("confirm-day")[0].onclick = function () {
//    //获取输入的周数
//    //parseInt(document.getElementsByName("day-amount")[0].value);
//    //算出是多少天的时间戳
//    //(parseInt(document.getElementsByName("day-amount")[0].value)  * 24 * 60 * 60 * 1000);
//    //获得开始是哪一天的时间戳 加上多少天的时间戳
//    //new Date((parseInt(new Date(document.getElementById('start-time').value).getTime())) + (parseInt(document.getElementsByName("week-amount")[0].value)  * 24 * 60 * 60 * 1000);
//    //获取结束年份
//    var dayYear = (new Date((parseInt(new Date(document.getElementById('start-time').value).getTime())) + ((parseInt(document.getElementsByName("day-amount")[0].value)) * 24 * 60 * 60 * 1000))).getFullYear();
//    //获取结束月份
//    var dayMonth = (new Date((parseInt(new Date(document.getElementById('start-time').value).getTime())) + ((parseInt(document.getElementsByName("day-amount")[0].value)) * 24 * 60 * 60 * 1000))).getMonth();
//    //获取结束日期
//    var dayDay = (new Date((parseInt(new Date(document.getElementById('start-time').value).getTime())) + ((parseInt(document.getElementsByName("day-amount")[0].value)) * 24 * 60 * 60 * 1000))).getDate();
//    var dayWeek = Math.floor(parseInt(document.getElementsByName("day-amount")[0].value) / 7);
//    var dayResidue = parseInt(document.getElementsByName("day-amount")[0].value) % 7;
//    document.getElementById("over-day").innerHTML = "课程截止到" + dayYear + "年" + dayMonth + "月" + dayDay + "日,一共" + dayWeek + "周零" + dayResidue + "天,学费:" + parseInt(document.getElementsByName("day-amount")[0].value * 986 / 7) + "元";
//}


//2.使用正则表达式判断某个字符串:
//是否是合格的Email格式
//邮箱组成:_12qq.s2@12w.con.net      _12qq  .  s2  @  12w  .con  .net
//  1.下划线或数字或英文字母    2 .和数字或英文字母    3.@     4.数字或字母     5 .和英文字母     6 .和英文字母
//  1.\w                      2.    \.\w            3.@    4.A_z0_9
//是否是小数（正负小数都可以）
//将所有以zyf - 开头的属性去掉zyf - （尽可能多的制造测试用例，
//比如：<a lzyf-old=''， 或者：<span>zyf---+---fyz</span> ……）


//JSON生成和解析：
//按自己的情况，生成一个JSON字符串，包括真实姓名、QQ昵称、年龄、性别、兴趣爱好、自我介绍……，上传到QQ群：一起帮·有意向（729600626）
//根据其他同学的JSON获得其个人资料，生成一个表格显示。 
//var cxk = {
//    name: "cxk",
//    job: "NBAambassador",
//    age: 20,
//    gender: "male",
//    hobby: ['sing', 'jump', 'rap'],
//    introduction: "Just because you are so beautiful",
//    course: {

//    }
//}

//var wx = {
//    name: "文轩",
//    QQname: "ฅ(๑ ̀ㅅ ́๑)ฅ",
//    age: 20,
//    gender: "male",
//    hobby: ['listenSongs', 'watchMovie'],
//    introduction: "Just because you are so beautiful",
//    couese: {
//        'C#': 86,
//        'HTML/CSS/JavaScript': 95,
//        SQL: 92,
//        'ASP.NET': null
//    }
//}

//console.log(JSON.stringify(wx));


