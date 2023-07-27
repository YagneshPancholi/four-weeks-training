class Student {
    constructor(name, grade) {
        this.name = name;
        this.grade = grade;
        this.courses = [];
    }
    addCourse(courseName) {
        this.courses.push(courseName);
    }
    removeCourse(courseName) {
        var index = this.courses.indexOf(courseName);
        if (index != -1) {
            this.courses.splice(index, 1);
        }
    }
}

function studentWithThisCourse(students, courseName){
    return students.filter(x => x.courses.includes(courseName));
}


let student1 = new Student("Yagnesh Pancholi", 12);
var student2 = new Student("Kunal Shah",11);

student1.addCourse("Chemistry");
student1.addCourse("Physics");
student1.addCourse("Maths");

console.log("before");
console.log(student1.courses);
student1.removeCourse("Chemistry");
console.log("after");
console.log(student1.courses);

student2.addCourse("Physics");
student2.addCourse("Chemistry");
student2.addCourse("Bio");

console.log(student1);
console.log(student2);

var students = [student1,student2];
console.log(students);

var ans = studentWithThisCourse(students, "Physics");
// console.log(ans);
ans.forEach(element => {
  console.log(element);  
});