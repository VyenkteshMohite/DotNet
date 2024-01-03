namespace Util;
using System.Threading;
public static class Helper{
    //non blocking call
        public static  async  Task  StoreData(){
            // defining callback function and invoking callback function
            // using internal thread pool
              await Task.Run(()=>{
				  //arrow => operator to quickly define JavaScript functions,
				  //with or without parameters
                    Console.WriteLine("StoreData Function Called ...");
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            });
        }

        public static  async  Task  GetRemoteData(){
             await Task.Run(()=>{
                Console.WriteLine("GetRemoteData Function Called !!");
                 Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            });
        }


}
































// namespace util;
// using System.Threading;

// public static class Helper{
	
// 	public static async Task StoreData(){
// 		await Task.Run(()=>{
// 			Console.WriteLine("Calling StoreData....");
// 			Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
// 	});
// }