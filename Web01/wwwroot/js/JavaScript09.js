//1.用class声明一个课程（Course），包含属性：name，startDate，endDate，students，以及方法：begin()和end()
class Course {
    constructor(name, startDate, students) {
        this.name = name;
        this.startDate = startDate;
        this.endDate = "2019/12/31";
        this.students = students;
    }
    end() {
        console.log(`${this.name}于${this.endDate}结束，共有${this.students.length}名同学(${this.students})听完`);
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
    static getStudentsByName(course) {
        console.log(`参加${course.name}课程的有${course.students.length}名同学`)
        //能根据不同的name返回不同的整数值（参加该course的学生数量）
    }
}

//2.生成两个课程对象：JavaScript和SQL
var Javascript = new Course("JavaScript", "2019/5/5", ["两开花", "王枫", "王平", "采铃", "老程"]);
var SQL = new Course("SQL", "2019/5/26", ["两开花", "王枫", "王平", "采铃", "老程"])

//3.调用对象的begin()和end()方法，可以在控制台输出开课信息，
//    如：JavaScript于2019年5月5日开课，共有5名同学（两开花、王枫、王平、采铃、老程）报名。

Javascript.begin();
SQL.begin();

////4.不修改class，动态的改变begin()方法，使其能影响所有Course对象

//Course.prototype.begin = function () { console.log(this.name + "不开课了!") };
//Javascript.begin();
//SQL.begin();

////5.让end()方法为各自对象“自有”，其他对象无法修改
//写在constructor中

//6.在Course中使用getter和setter包装endDate，保证endDate不会小于startDate，也不会比startDate多出365天

////测试用例:1.Javascript开始时间设置为"2019/5/5",结束日期设置为"2019/5/25",
//javascript.enddate="2019/5/25";
////控制台输出: javascript于2019/5/25结束，共有5名同学(两开花、王枫、王平、采铃、老程)听完`
//javascript.end();

////测试用例:2.Javascript开始时间设置为"2019/5/5",结束日期设置为"2019/4/25",
//Javascript.EndDate = "2019/4/25";
////控制台输出: 结束时间小于开始时间 后 输出 Javascript于"2019/12/31"结束，共有5名同学(两开花、王枫、王平、采铃、老程)听完`
//Javascript.end();

////测试用例:3.Javascript开始时间设置为"2019/5/5",结束日期设置为"2018/4/25",
//Javascript.EndDate = "2018/4/25";
////控制台输出: 时间不正确 后 输出 Javascript于"2019/12/31"结束，共有5名同学(两开花、王枫、王平、采铃、老程)听完`
//Javascript.end();
SQL.enddate = "2019/4/25";

//7.判断并证明以下说法：
//  1.ES里的class其实就是一个function 对
//typeof Course
//  2.constructor总是返回class的实例 错
//在class中return一个对象
//返回的就不是

//  3.当new了一个class之后，class里声明的方法就会被copy到新生成的实例对象上
//Javascript.__proto__.constructor
//SQL.__proto__.constructor
//  4.JavaScript里面，类就是对象，对象也是类  对
//Function instanceof Object;
//Object instanceof Function;

//  5.只有Function才有prototype   对
//SQL.prototype  调不出来
//  6.Javascript是动态类型语言，所以对象的类型是可以随意更改的 
//一个对象作为谁的实例是可以更改的,修改prototype.
//但是 typeof 对象 一直是 Object;


//继承
//2.声明一个Stundent类，包含name和score两个属性，让Course的Students包含的是Student的对象
class Student {
    constructor(name, score) {
        this.name = name;
        this.score = score;
    }
}

var lkh = new Student("两开花", 99),
    wf = new Student("王枫", 98),
    wp = new Student("王平", 97),
    cl = new Student("采铃", 96),
    lc = new Student("老程", 95);

var csharp = new Course("C#", "2019/6/1", [lkh, wf, wp, cl, lc]);

//1.最封装作业的基础上，为Course添加两个子类：
//  主修课（MajorCourse）和辅修课（ElectiveCourse） 

//3.主修课需要参加考试，所以有一个Exam(student)方法；
//  辅修课只需要测评，所以有一个方法Assess(student) 
class MajorCourse extends Course {
    constructor(name, startDate, students) {
        super(name, startDate, students);
    }
    Exam(student) {
        student.score = Math.floor(Math.random() * 50 + 50);
        super.end();
        console.log(`${student.name}${student.score}`);
    }
};

class ElectiveCourse extends Course {
    constructor(name, startDate, student) {
        super(name, startDate, student);
    }
    Assess(student) {
        var AssessScoreArr = "ABCDE";

        student.score = AssessScoreArr[Math.floor(Math.random() * 5)];
        super.end();
        console.log(`${student.name}${student.score}`);
    }
};
//4.创建一个MajorCourse的实例，运行它的Exam (student)方法，结束课程（使用end()方法），
//  并给该student的score赋值为50 - 100的随机整数 
var java = new MajorCourse("Java", "2019/7/1", [lkh, wf, wp, cl, lc]);
//java.EndDate = "2019/7/25"
//java.Exam(lkh);
//java.end();

//5.创建一个ElectiveCourse的实例，运行它的Assess(student)方法，
//    结束课程（使用end()方法），给该student的score赋值为ABCDE中的一个随机值
//var php = new ElectiveCourse("PHP", "2019/7/26", [lkh, wf, wp, cl, lc]);
//php.EndDate = "2019/7/30";
//php.Assess(lkh);
//php.end();
//6.给Course声明一个静态的GetStudentsByName(name) ，
//    能根据不同的name返回不同的整数值（参加该course的学生数量）
//Course.getStudentsByName(Javascript);
//7.在子类调用GetStudentsByName(name)
//ElectiveCourse.getStudentsByName(Javascript);
//8.说明：为什么子类可以继承父类的实例和静态方法？

//MajorCourse.__proto__ === Course
//java.__proto__.__proto__ === Course.prototype
//Course.hasOwnProperty("getStudentsByName")