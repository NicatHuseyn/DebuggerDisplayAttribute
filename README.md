<h1>DebuggerDisplay Attribute Nədir?</h1>

  <p>
    DebuggerDisplay attribute, C# proqramlaşdırma dilində bir class və ya struct
    bəyan etdikdə istifadə edilən bir attributdur. Bu attribut ilə Visual Studio
    debugger-ində obyektlərin necə görünəcəyini özəlləşdirə biləcək və beləcə
    debug-ı daha asan və təsirli edəcəyik.
    <br />
    DebuggerDisplay, adətən qarışıq olan class-ların obyektlərini debugger ilə
    nəzarət edərkən istifadəyə yararlıdır. Belə ki...
  </p>
  <br />
  <div style="width: 500px">
    <img src="https://github.com/user-attachments/assets/41792f2b-1d77-4d88-a2c4-749791355ee0" style="width: 500px" alt="" />
  </div>
  <br />
  <p>
    Yuxarıdakı koddan görüldüyü kimi normalda kodu debug etdikdə bu şəkildə
    görünür.
    <br />
    Belə sadə class-ları debug etmək sadə görünə bilər, lakin içərisində çox
    sayda member-ları olan class-lar ola bilər. Bu class-ları debug edərkən bu
    şəkildə debug edilməsi çox da istifadəyə yararlı deyil. Daha yaxşı bir üsulu
    var, o da DebuggerDisplay
  </p>

  <div style="width: 500px">
    <img src="https://github.com/user-attachments/assets/5afd84be-fc39-4aa3-b402-16e1d76d15dd" style="width: 500px" alt="" />
  </div>
  <p>
    Yuxarıda görüldüyü kimi class-ı DebuggerDisplay attributu ilə işarələyirik.
  </p>
  <div style="width: 500px">
    <img src="https://github.com/user-attachments/assets/0bea074e-fc5d-4488-8d24-32b73bb09df9" style="width: 500px" alt="" />
  </div>
  <p>
    Görüldüyü kimi DebuggerDisplay attribute sayəsində bir obyektin sürətli bir
    şəkildə incələnməsi asanlaşır və yazılı olaraq bəyan edilmiş property-lərin
    dəyərləri yuxarıdakı kimi göstərilir.
    <br />
    Həmçinin debugging zamanı qarışıq obyektlərin içərisindəkilərlə oynamaq
    əvəzinə, debugger vasitəsilə developer-ə məlumat verə bilir.
    <br />
    Böyük və qarışıq layihələrdə bu özəllilkdən istifadə etmək olar. Debugging
    zamanı işin gedişatını sürətləndirir bu attribute istifadə etmək.
  </p>
