//在函数yz.fei.get986()中嵌入不带参数的函数has9() / has8() / has6() ，
//并调用上述函数，找出10000以内有多少个数字包含：9或者8或者6。 

//var yz = {};
//yz.fei = {};


//get986 = function (max) {
//    //遍历max以内的数字
//    var arr9 = [];
//    var arr8 = [];
//    var arr6 = [];
//    for (var i = 0; i <= max; i++) {
//        //将数字转换成字符串
//        var no = i.toString()
//        for (var j = 0; j < no.length; j++) {
//            if (parseInt(no[j]) === 9) {
//                arr9.push(i);
//            }
//            if (parseInt(no[j]) === 8) {
//                arr8.push(i);
//            }
//            if (parseInt(no[j]) === 6) {
//                arr6.push(i);
//            }

//            var arrCenter = arr9.concat(arr8).concat(arr6);
//            arrCenter = arrCenter.concat(arr6);
//            ArrRemoveDuplication1(arrCenter);
//        }
//    }
//    return alert(arrCenter.length);
//}
//get986(100);


////去重函数
//function ArrRemoveDuplication1(arr) {
//for (var i = 0; i < arr.length; i++) {
//    //alert(arr6[i]);
//    //遍历当前元素后的那个元素
//    for (var j = i + 1; j < arr.length; j++) {
//        //alert(arr6[j]);
//        if (arr[i] === arr[j]) {
//            arr.splice(j, 1);
//            j--;
//        }
//    }
//    }
//    return arr;
//}

