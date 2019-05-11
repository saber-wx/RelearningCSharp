
//QUESTION2.1.统计有多少个悬赏大于1的求助
//var count = 0;
//function amount() {
//    var moneyNumbers = document.getElementsByName("moneyNumbers");
//    for (let i = 0; i < moneyNumbers.length; i++) {
//        if (moneyNumbers[i].textContent > 1) {
//            count++;
//        }
//    }
//    return console.log("悬赏大与1的求助有" + count + "个")
//}

////QUESTION2.2.将状态为“协助中”的求助背景改成灰黑色
//var state = document.getElementsByClassName('state');
//function helpState() {
//    for (let i = 0; i < state.length; i++) {
//        if (state[i].textContent === '协助中') {
//            state[i].parentNode.parentNode.style = "background:#D0D0D0;"
//        }
//    }
//}

////QUESTION2.3.写一个函数，可以统计某个求助使用了多少关键字
////获得关键字标签
//var keyword = document.getElementsByClassName('keword');
//function keywordAmount() {
//    for (let i = 0; i < keyword.length; i++) {
//        //取得关键字个数
//        var keywordAmounts = keyword[i].getElementsByTagName('a').length;
//        //获得求助标题
//        var helpContent = keyword[i].previousElementSibling.children[0].textContent;
//        //打印
//        console.log(`标题为"${helpContent}"的求助有"${keywordAmounts}"个关键字`);
//    }
//}

////QUESTION2.4.如果总结数为0,将其从DOM树中删除

////取得总结数
//var sumupNumbers = document.getElementsByName("sum-upNumbers");
//function deleteAmountIsZero() {
//    for (let i = 0; i < sumupNumbers.length; i++) {
//        //总结数为0,删掉整个求助
//        if (parseInt(sumupNumbers[i].textContent) === 0) {
//            sumupNumbers[i].parentNode.parentNode.parentNode.remove();
//        }
//    }
//}

//function implement() {
//    helpState();
////    amount();
//////    keywordAmount();
//////    //deleteAmountIsZero();
//}


//// QUESTION1:实现铃铛闪烁效果
//var flag = false;
//function start() {

//    var temp = document.getElementById("flicker");
//    if (!flag) {
//        temp.style.color = "blue";
//        flag = 1;
//    } else {
//        temp.style.color = "red";
//        flag = 0;
//    }
//    setTimeout(start, 500);
//}

////QUESTION3.1显示密码的长度
//document.getElementsByTagName('input')[1].onkeydown = function () {
//    console.log("密码长度" + document.getElementsByTagName('input')[1].value.length);
//}

////QUESTION3.2如果密码和确认密码不一致，弹出提示
//document.getElementsByClassName('submits')[0].onclick = function() {
//    let password = document.getElementsByTagName('input')[1].value;
//    let passwordConfirm = document.getElementsByTagName('input')[2].value;
//    if (password !== passwordConfirm) {
//        alert("两次密码输入不一致!");
//    }
//}


////QUESTION4.参考用户资料页面，控制台显示出用户的：性别 / 出生年月 / 关注（关键字）/ 自我介绍
////取得用户名

//function users() {
//    var userName = document.getElementsByClassName("user")[0].getElementsByTagName('a')[0].textContent;
//    //取得用户性别
//    var gender = document.getElementsByClassName("gender")[0].childNodes[3].textContent;
//    //取得用户生日
//    var birthday = document.getElementsByClassName("birthday")[0].textContent;
//    //取得用户所有关键字节点
//    var keyword = document.getElementsByClassName("keyword")[0].getElementsByTagName("span");
//    var keywordArr = [];
//    //遍历每个关键字
//    for (let i = 0; i < keyword.length; i++) {
//        var keywords = keyword[i].textContent;
//        //将关键字装进数组
//        keywordArr.push(keywords);
//    }
//    var introduceSelf = document.getElementsByClassName("introduceSelf")[0].getElementsByTagName('p')[0].textContent;
//    console.log(`用户名为"${userName}"的用户是一位${gender}神`)
//    console.log(`${birthday}关注的关键字有:${keywordArr}`)
//    console.log(`是一位${introduceSelf}`)
//}

//1.参考求助首页侧边栏关键字，实现：当鼠标移动到关键字上，显示关键字被使用次数 
//直接在HTML页面中以属性"title"显示

//2.参考文章的全系列阅读功能，当滚动到页面底部时，将页面现有内容粘贴到页面底部，直到5次过后，在页面底部显示：已经没有更多内容了 


////3.参考消息页面：完成勾选全选功能 

//document.getElementsByName('checkAll')[0].onclick = function () {
//    for (var i = 0; i < document.getElementsByName('check').length; i++) {
//        document.getElementsByName('check')[i].checked = this.checked;
//    }
//}

////4.参考注册页面：
////提交时，如果用户名重复（已有用户名用数组保存），阻止form提交，提示“用户名重复”。
////重新输入用户名，一旦输入用户名部分没有重复，“用户名重复”的提示消失
////当用户名或密码等有值时，关闭页面前弹出确认框 

//var arrUserName = ["叶飞", "钟锦程", "赵昱泽", "金路炜", "龙俊升", "刘子祥", "文轩", "王枫", "王平","233"];
//var useNameInput = document.getElementsByName('username')[0];
//useNameInput.onmouseover = function () {
//    for (let i = 0; i < arrUserName.length; i++) {
//        if (useNameInput.value === arrUserName[i]) {
//            document.getElementsByTagName("p")[0].style.display = "block";
//            break;
//        } else {
//            document.getElementsByTagName("p")[0].style.display = "none";
//        }
//    }
//}

////阻止form提交
//document.getElementsByClassName('register-submits')[0].onclick = function (event) {
//    for (let i = 0; i < arrUserName.length; i++) {
//        if (useNameInput.value === arrUserName[i]) {
//            alert('用户名重复');
//            event.preventDefault();
//        }
//    }
//}

////当用户名或密码等有值时，关闭页面前弹出确认框 
//window.addEventListener('beforeunload', function (e) {
//    if (document.getElementsByName('username')[0].value !== "" || document.getElementsByTagName('input')[1].value !== "") {
//        e.preventDefault();
//    }
//})

//5.参考求助首页侧边栏“免费广告发布”弹出Modal，实现（不需要弹出Modal）：
//根据下拉列表选中项，填充“文字内容”和“链接”文本框
//勾选修改的checkbox，实现“文字内容”和“链接”文本框的禁用和启用

//6.参考发布求助，实现其关键字功能：
//没有选择一级关键字，不能选择二级关键字
//选择一级关键字后，二级关键字只能是一级关键字下的子集
//一级关键字和二级关键字被选中后，会显示在下拉列表上方
//自定义关键字输入完成后（按空格键），输入的关键字显示在下拉列表上方
//后输入的关键字显示在前面 

