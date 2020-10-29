/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 80017
Source Host           : localhost:3306
Source Database       : service_test

Target Server Type    : MYSQL
Target Server Version : 80017
File Encoding         : 65001

Date: 2020-10-28 14:58:00
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for customers
-- ----------------------------
DROP TABLE IF EXISTS `customers`;
CREATE TABLE `customers` (
  `cus_id` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `cus_name` varchar(255) DEFAULT NULL,
  `cus_shop` varchar(255) DEFAULT NULL,
  `cus_address` varchar(255) DEFAULT NULL,
  `cus_tell` varchar(255) DEFAULT NULL,
  `cus_email` varchar(255) DEFAULT NULL,
  `cus_taxid` varchar(255) DEFAULT NULL,
  `cus_details` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`cus_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of customers
-- ----------------------------
INSERT INTO `customers` VALUES ('CUS00001', 'คุณบอล', 'ร้านชาบุ', 'อ.เมือง จ.บุรีรัม', '0875962100', '-', '1355900', '-');
INSERT INTO `customers` VALUES ('CUS00002', 'คุณดา', 'ร้านอาหารตามสั่ง', 'อ.เมือง จ.นครราชสีมา', '0902115489', '-', '321550466', '-');

-- ----------------------------
-- Table structure for cus_repair
-- ----------------------------
DROP TABLE IF EXISTS `cus_repair`;
CREATE TABLE `cus_repair` (
  `repair_id` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `cus_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `shop_name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `address` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `tell` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `email` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `tax_id` varchar(15) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `topic` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `price` int(10) NOT NULL,
  `repair_details` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `repair_status` int(4) NOT NULL,
  `remark` text CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `emp` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `emp_edit` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `date_add` datetime NOT NULL,
  `date_edit` datetime NOT NULL,
  `date_send_cus` datetime NOT NULL,
  PRIMARY KEY (`repair_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of cus_repair
-- ----------------------------
INSERT INTO `cus_repair` VALUES ('REP00002', 'คุณบอล', 'ร้านชาบุ', 'อ.เมือง จ.โคราช', '0875962100', '-', '1355900', 'เครื่อง POS เปิดไม่ติด', '1000', 'เปลี่ยนจอ', '0', '-', 'อาม', 'ศรายูทธ ไกรษร', '2020-09-27 01:46:22', '2020-10-02 11:20:16', '2020-09-10 16:31:08');
INSERT INTO `cus_repair` VALUES ('REP00003', 'คุณบอล', 'ร้านชาบุ', 'อ.เมือง จ.บุรีรัม', '0875962100', '-', '1355900', 'ทดสอบการแจ้งซ่อม', '1500', 'ซ่อมเครื่อง POS', '0', '-', 'อาม', '', '2020-09-27 16:37:58', '2020-09-27 16:37:58', '2020-09-10 16:31:08');
INSERT INTO `cus_repair` VALUES ('REP00004', 'คุณบอล', 'ร้านชาบุ', 'อ.เมือง จ.บุรีรัม', '0875962100', '-', '1355900', '121212', '101010', '๑๒๑๒ไพไพไพ', '-1', '๑๒๑ไพไพไพไพ', '๑๑๒', 'ศรายูทธ ไกรษร', '2020-10-19 08:48:58', '2020-10-19 08:49:13', '2020-09-10 16:31:08');
INSERT INTO `cus_repair` VALUES ('REP00005', 'คุณบอล', 'ร้านชาบุ', 'อ.เมือง จ.บุรีรัม', '0875962100', '-', '1355900', 'asdasd', '0', 'asdas', '0', 'dasdas', 'asdasd', '', '2020-10-21 16:02:46', '2020-10-21 16:02:46', '2020-09-10 16:31:08');

-- ----------------------------
-- Table structure for employee
-- ----------------------------
DROP TABLE IF EXISTS `employee`;
CREATE TABLE `employee` (
  `Emp_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Emp_name` varchar(255) NOT NULL,
  `Emp_card_ID` int(11) DEFAULT NULL,
  `Emp_sex` varchar(255) DEFAULT NULL,
  `Emp_tel` varchar(255) DEFAULT NULL,
  `Emp_add_register` date DEFAULT NULL,
  `Username` varchar(255) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Emp_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of employee
-- ----------------------------
INSERT INTO `employee` VALUES ('1', 'ศรายูทธ ไกรษร', '2147483647', 'ชาย', '087260557', '2020-09-25', '007', '123');
INSERT INTO `employee` VALUES ('2', 'อาม', '2147483647', 'ชาย', '08755643321', '2020-10-27', '008', '123');

-- ----------------------------
-- Table structure for equipment_insert
-- ----------------------------
DROP TABLE IF EXISTS `equipment_insert`;
CREATE TABLE `equipment_insert` (
  `equipment_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Number_insert` varchar(255) DEFAULT NULL,
  `equipment_name` varchar(255) DEFAULT NULL,
  `equipment_totall` int(255) DEFAULT NULL,
  `equipment_unit` varchar(255) DEFAULT NULL,
  `equipment_price` int(11) DEFAULT NULL,
  `equipment_date_insert` datetime DEFAULT NULL,
  `equipment_date_update` datetime DEFAULT NULL,
  `equipment_Emp` varchar(255) DEFAULT NULL,
  `equipment_status` varchar(255) DEFAULT NULL,
  `Stock_ID` int(11) DEFAULT NULL,
  PRIMARY KEY (`equipment_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of equipment_insert
-- ----------------------------
INSERT INTO `equipment_insert` VALUES ('14', 'N-00000001', 'เครื่อง POS', '100', 'เครื่อง', '0', '2020-09-16 11:52:36', '2020-10-08 15:27:51', 'ศรายูทธ ไกรษร', 'ใช้งาน', '2');
INSERT INTO `equipment_insert` VALUES ('15', 'N-00000001', 'ปริ้นเตอร์ 80mm', '100', 'เครื่อง', '0', '2020-09-16 11:52:36', '2020-10-08 15:27:51', 'ศรายูทธ ไกรษร', 'ใช้งาน', '3');
INSERT INTO `equipment_insert` VALUES ('16', 'N-00000001', 'ปริ้นเตอร์ 58mm', '100', 'เครื่อง', '0', '2020-09-16 11:52:36', '2020-10-08 15:27:51', 'ศรายูทธ ไกรษร', 'ไม่ใช้งาน', '4');
INSERT INTO `equipment_insert` VALUES ('17', 'N-00000001', 'ลิ้นชัก 7 ช่อง', '1000', 'เครื่อง', '0', '2020-09-16 11:52:36', '2020-10-08 15:27:51', 'ศรายูทธ ไกรษร', 'ไม่ใช้งาน', '5');
INSERT INTO `equipment_insert` VALUES ('18', 'N-00000002', 'ปริ้นเตอร์ 80mm', '100', 'เครื่อง', '100', '2020-09-17 11:52:36', '2020-10-09 08:59:29', 'ศรายูทธ ไกรษร', 'ใช้งาน', '3');
INSERT INTO `equipment_insert` VALUES ('19', 'N-00000003', 'เครื่อง POS', '10', 'เครื่อง', '5000', '2020-09-16 11:52:36', '2020-10-09 09:11:14', 'ศรายูทธ ไกรษร', 'ใช้งาน', '2');
INSERT INTO `equipment_insert` VALUES ('20', 'N-00000003', 'ปริ้นเตอร์ 80mm', '10', 'เครื่อง', '500', '2020-09-16 11:52:36', '2020-10-09 09:11:14', 'ศรายูทธ ไกรษร', 'ใช้งาน', '3');
INSERT INTO `equipment_insert` VALUES ('26', '132', 'เครื่อง POS', '10', 'เครื่อง', '0', '2020-09-18 11:52:36', '2020-10-26 08:56:09', 'ศรายูทธ ไกรษร', 'ใช้งาน', '2');
INSERT INTO `equipment_insert` VALUES ('27', 'N-00000004', 'ปริ้นเตอร์ 80mm', '10', 'เครื่อง', '0', '2020-09-18 11:52:36', '2020-10-26 08:56:24', 'ศรายูทธ ไกรษร', 'ใช้งาน', '3');

-- ----------------------------
-- Table structure for stock_pos
-- ----------------------------
DROP TABLE IF EXISTS `stock_pos`;
CREATE TABLE `stock_pos` (
  `Stock_ID` int(11) NOT NULL AUTO_INCREMENT,
  `Stock_name` varchar(255) DEFAULT NULL,
  `Stock_deteil` varchar(255) DEFAULT NULL,
  `Stock_remark` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT '-',
  `Stock_status` varchar(255) DEFAULT NULL,
  `Stock_price` int(11) DEFAULT NULL,
  `Number_devices` int(11) DEFAULT NULL,
  `Stock_unit` varchar(20) DEFAULT NULL,
  `Stock_date_insert` datetime DEFAULT NULL,
  `Stock_date_edit` datetime DEFAULT NULL,
  PRIMARY KEY (`Stock_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of stock_pos
-- ----------------------------
INSERT INTO `stock_pos` VALUES ('2', 'เครื่อง POS', '-', '-', 'ใช้งาน', '6000', '380', 'เครื่อง', '2020-09-27 01:47:16', '2020-09-27 01:47:16');
INSERT INTO `stock_pos` VALUES ('3', 'ปริ้นเตอร์ 80mm', '-', '-', 'ใช้งาน', '500', '850', 'เครื่อง', '2020-09-29 08:51:00', '2020-10-16 10:02:46');
INSERT INTO `stock_pos` VALUES ('4', 'ปริ้นเตอร์ 58mm', '-', '-', 'ใช้งาน', '200', '100', 'เครื่อง', '2020-09-29 08:51:16', '2020-09-29 08:51:16');
INSERT INTO `stock_pos` VALUES ('5', 'ลิ้นชัก 7 ช่อง', '-', '-', 'ใช้งาน', '1000', '100', 'เครื่อง', '2020-09-29 08:51:35', '2020-09-29 08:51:35');
INSERT INTO `stock_pos` VALUES ('8', 'เครื่องยิงบาโค๊ด', '-', '-', 'ใช้งาน', '500', '0', 'อัน', '2020-10-16 10:03:16', '2020-10-16 10:03:16');

-- ----------------------------
-- Table structure for table_list
-- ----------------------------
DROP TABLE IF EXISTS `table_list`;
CREATE TABLE `table_list` (
  `List_ID` int(11) NOT NULL AUTO_INCREMENT,
  `List_ID_take_out` varchar(200) DEFAULT NULL,
  `List_date_send_customer` datetime DEFAULT NULL,
  `List_date_get_back` datetime DEFAULT NULL,
  `List_deteil` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `List_remark` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `List_status` varchar(255) DEFAULT NULL,
  `List_total` int(255) DEFAULT NULL,
  `cus_id` varchar(255) DEFAULT NULL,
  `Stock_ID` int(20) DEFAULT NULL,
  PRIMARY KEY (`List_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=62 DEFAULT CHARSET=utf8 ROW_FORMAT=DYNAMIC;

-- ----------------------------
-- Records of table_list
-- ----------------------------
INSERT INTO `table_list` VALUES ('61', 'B-00000001', '2020-09-06 16:17:25', '2020-09-10 16:17:25', '', 'System.Windows.Forms.TextBox, Text: -', 'ส่งให้ลูกค้าเรียบร้อย', '10', 'CUS00002', '2');
