//1.用class声明一个课程（Course），包含属性：name，startDate，endDate，students，以及方法：begin()和end()
class Course {
    constructor(name, startDate, students) {
        this.name = name;
        this.startDate = startDate;
        this.endDate = "2019/12/31";
        this.students = students;
        this.end = function end() {
            console.log(`${this.name}于${this.endDate}结束，共有${this.students.length}名同学(${this.students})听完`);
        }
    }
    get EndDate() {
        return this.endDate;
    }
    set EndDate(value) {
        let gap = Date.parse(value) - Date.parse(this.startDate);
        const oneYear = 365 * 24 * 60 * 60 * 1000;
        if (gap < 0) {
            console.log("结束时间小于开始时间!")
            //throw new DOMException("end date is wrong");
        } else if (gap > oneYear) {
            console.log("时间大于一年!")
            //throw new DOMException("end date is wrong");
        } else {
            this.endDate = value;
        }
    }
    begin() {
        console.log(`${this.name}于${this.startDate}开课，共有${this.students.length}名同学(${this.students})报名`);
    }
}


//2.生成两个课程对象：JavaScript和SQL
var Javascript = new Course("JavaScript", "2019/5/5", ["两开花", "王枫", "王平", "采铃", "老程"]);
var SQL = new Course("SQL", "2019/5/26", ["两开花", "王枫", "王平", "采铃", "老程"])


//3.调用对象的begin()和end()方法，可以在控制台输出开课信息，
//    如：JavaScript于2019年5月5日开课，共有5名同学（两开花、王枫、王平、采铃、老程）报名。

//Javascript.begin();
//SQL.begin();

////4.不修改class，动态的改变begin()方法，使其能影响所有Course对象

//Course.prototype.begin = function () { console.log(this.name + "不开课了!") };
//Javascript.begin();
//SQL.begin();

////5.让end()方法为各自对象“自有”，其他对象无法修改
//写在constructor中

//6.在Course中使用getter和setter包装endDate，保证endDate不会小于startDate，也不会比startDate多出365天

////测试用例:1.Javascript开始时间设置为"2019/5/5",结束日期设置为"2019/5/25",
//Javascript.EndDate="2019/5/25";
////控制台输出: Javascript于2019/5/25结束，共有5名同学(两开花、王枫、王平、采铃、老程)听完`
//Javascript.end();

////测试用例:2.Javascript开始时间设置为"2019/5/5",结束日期设置为"2019/4/25",
//Javascript.EndDate = "2019/4/25";
////控制台输出: 结束时间小于开始时间 后 输出 Javascript于"2019/12/31"结束，共有5名同学(两开花、王枫、王平、采铃、老程)听完`
//Javascript.end();

////测试用例:3.Javascript开始时间设置为"2019/5/5",结束日期设置为"2018/4/25",
//Javascript.EndDate = "2018/4/25";
////控制台输出: 时间不正确 后 输出 Javascript于"2019/12/31"结束，共有5名同学(两开花、王枫、王平、采铃、老程)听完`
//Javascript.end();

//7.判断并证明以下说法：
//  1.ES里的class其实就是一个function
//typeof Course
//  2.constructor总是返回class的实例
//Course.prototype;
//Javascript.prototype.__proto__
//  3.当new了一个class之后，class里声明的方法就会被copy到新生成的实例对象上
//Javascript.__proto__.constructor
//SQL.__proto__.constructor
//  4.JavaScript里面，类就是对象，对象也是类

//  5.只有Function才有prototype
//  6.Javascript是动态类型语言，所以对象的类型是可以随意更改的 
//var obj = { name: "saber" };
//obj = null;