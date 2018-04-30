/*
Navicat MySQL Data Transfer

Source Server         : tr
Source Server Version : 50626
Source Host           : localhost:3306
Source Database       : te

Target Server Type    : MYSQL
Target Server Version : 50626
File Encoding         : 65001

Date: 2015-12-28 23:04:23
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `uname` varchar(100) DEFAULT NULL,
  `pwd` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES ('administrator', '123456');

-- ----------------------------
-- Table structure for xs
-- ----------------------------
DROP TABLE IF EXISTS `xs`;
CREATE TABLE `xs` (
  `xh` varchar(100) DEFAULT NULL,
  `xm` varchar(100) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `xy` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of xs
-- ----------------------------
INSERT INTO `xs` VALUES ('1301', '胡美娟', '20', '信息与安全工程学院');
INSERT INTO `xs` VALUES ('1202', '张三', '21', '会计学院');
INSERT INTO `xs` VALUES ('1403', '李四', '19', '金融学院');
INSERT INTO `xs` VALUES ('1204', '余波', '21', '传媒学院');
INSERT INTO `xs` VALUES ('1402', '李梅', '20', '外语学院');
INSERT INTO `xs` VALUES ('1101', '何静', '23', '法学院');
INSERT INTO `xs` VALUES ('1303', '吴晶', '21', '刑司学院');
INSERT INTO `xs` VALUES ('1111', '徐来', '22', '哲学院');
