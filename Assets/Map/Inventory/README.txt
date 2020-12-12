Inventory 使用教程：
   （老手请看这：给人物ShowInventory.cs，并挂载new Inventory（背包实体），和bag panel（背包显示）Badslot prefab
                 给物品ItemOnWorld.cs，box collider， 并挂载new ItemDataModel）
        按g得到物品

        简介：要实现背包存储，我们需要 1.物体  2.背包
	
	物体Item由三部分组成： 
			1. 游戏内显示：在世界坐标中的sprit  
			2. 数据实体：物体的内部属性（是不是武器？多少把？）ItemDataModel ：：ScriptableObject
			3. 背包内显示：spirit显示在 背包内部的物品显示容器Bag Slot prefab
	背包由三部分组成：
			1. 游戏内显示：bag_panel 或者 inventory_panel
			2. 数据实体：存储item的List 数据结构 inventory ：： ScriptableObject
			3. 为物体Item提供外观显示容器：Bag Slot prefab
         
	1. 创建一个可用背包存储的物体：

		2. 使用：在游戏中放置一个spirit后，需要创建一个new ItemDataModel与sprite连接
                   
		   1. 创建new ItemDataModel：1.在Inventory/ItemDataModels文件夹下
					  2.鼠标右键点击create->Inventory->new ItemDataModel
               
                   2. 设置ItemDataModel中的物体属性（至少给个图片属性！！记住ItemDataModel是物体的描述）
                 
                   3. 连接ItemDataModel和spirit：
			       1. 将脚本ItemOnWorld.cs拖拽到spirit上，在脚本上添加ItemDataModel
		
		   ItemOnWorld.cs 用来控制spirit显示的样子（物体的显示） 
				  检测是否有背包捡到此物品（内部功能接口）
        2. 创建一个可存储物体的背包：
	   
                 1. 在Inventory/ItemDataModels文件夹下
		    鼠标右键点击create->Inventory->new Inventory 创建新背包
                    （请为你的背包改名，请不要和其他背包重名）
                    
      
                 2. 注意：背包是与角色挂钩的，所以要把背包挂载在gameObject上
				1. 先将脚本ShowInventory.cs挂载到gameObject上
                		2. 将新背包挂载在脚本下的公共变量中

                这样这就是一个有背包的object了！！！
		
 
                
			