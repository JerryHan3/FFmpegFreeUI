﻿
<Serializable()>
Public Class 预设数据类型
    Public Property 输出容器 As String = ""
    Public Property 自动混流同名字幕 As Boolean = False



    Public Property 解码参数_解码器 As String = ""
    Public Property 解码参数_解码数据格式 As String = ""



    Public Property 视频参数_编码器_类别 As String = ""
    Public Property 视频参数_编码器_具体编码 As String = ""
    Public Property 视频参数_编码器_质量 As String = ""
    Public Property 视频参数_编码器_配置文件 As String = ""
    Public Property 视频参数_编码器_场景优化 As String = ""
    Public Property 视频参数_分辨率 As String = ""
    Public Property 视频参数_分辨率自动计算_宽度 As String = ""
    Public Property 视频参数_分辨率自动计算_高度 As String = ""
    Public Property 视频参数_分辨率_裁剪滤镜参数 As String = ""
    Public Property 视频参数_帧速率 As String = ""
    Public Property 视频参数_帧速率_智能抽帧阈值 As String = ""
    Public Property 视频参数_比特率_控制方式 As String = ""
    Public Property 视频参数_比特率_基础 As String = ""
    Public Property 视频参数_比特率_最低值 As String = ""
    Public Property 视频参数_比特率_最高值 As String = ""
    Public Property 视频参数_比特率_缓冲区 As String = ""
    Public Property 视频参数_质量控制_参数 As String = ""
    Public Property 视频参数_质量控制_值 As String = ""
    Public Property 视频参数_质量控制_前瞻分析帧数 As String = ""
    Public Property 视频参数_质量控制_qpmin As String = ""
    Public Property 视频参数_质量控制_qpmax As String = ""
    Public Property 视频参数_质量控制_qpstep As String = ""
    Public Property 视频参数_质量控制_qp_i As String = ""
    Public Property 视频参数_质量控制_qp_p As String = ""
    Public Property 视频参数_质量控制_qp_b As String = ""
    Public Property 视频参数_质量控制_关键帧间隔 As String = ""
    Public Property 视频参数_质量控制_双向预测帧数量 As String = ""



    Public Property 视频参数_色彩管理_像素格式 As String = ""
    Public Property 视频参数_色彩管理_矩阵系数 As String = ""
    Public Property 视频参数_色彩管理_色域 As String = ""
    Public Property 视频参数_色彩管理_传输特性 As String = ""
    Public Property 视频参数_色彩管理_范围 As String = ""
    Public Property 视频参数_色彩管理_处理方式 As String = ""

    Public Property 视频参数_降噪_方式 As String = ""
    Public Property 视频参数_降噪_参数1 As String = ""
    Public Property 视频参数_降噪_参数2 As String = ""
    Public Property 视频参数_降噪_参数3 As String = ""
    Public Property 视频参数_降噪_参数4 As String = ""

    Public Property 视频参数_锐化_水平尺寸 As String = ""
    Public Property 视频参数_锐化_垂直尺寸 As String = ""
    Public Property 视频参数_锐化_锐化强度 As String = ""

    Public Property 视频参数_逐行与隔行_操作 As String = ""



    Public Property 音频参数_编码器_具体编码 As String = ""
    Public Property 音频参数_比特率_控制方式 As String = ""
    Public Property 音频参数_比特率_基础 As String = ""
    Public Property 音频参数_比特率_质量值 As String = ""
    Public Property 音频参数_声道数 As String = ""
    Public Property 音频参数_采样率 As String = ""
    Public Property 音频参数_响度标准化_目标响度 As String = ""
    Public Property 音频参数_响度标准化_动态范围 As String = ""
    Public Property 音频参数_响度标准化_峰值电平 As String = ""


    Public Property 图片参数_编码器_编码名称 As String = ""
    Public Property 图片参数_编码器_参数 As String = ""
    Public Property 图片参数_分辨率_宽度 As String = ""
    Public Property 图片参数_分辨率_高度 As String = ""


    Public Property 自定义参数_视频滤镜 As String = ""
    Public Property 自定义参数_音频滤镜 As String = ""
    Public Property 自定义参数_视频参数 As String = ""
    Public Property 自定义参数_音频参数 As String = ""
    Public Property 自定义参数_开头参数 As String = ""
    Public Property 自定义参数_之前参数 As String = ""
    Public Property 自定义参数_之后参数 As String = ""
    Public Property 自定义参数_最后参数 As String = ""



    Public Property 流控制_启用保留其他视频流 As Boolean = False
    Public Property 流控制_将视频参数应用于指定流 As String() = Array.Empty(Of String)()
    Public Property 流控制_启用保留其他音频流 As Boolean = False
    Public Property 流控制_将音频参数应用于指定流 As String() = Array.Empty(Of String)()
    Public Property 流控制_启动保留内嵌字幕流 As Boolean = False
    Public Property 流控制_启用保留元数据 As Boolean = False
    Public Property 流控制_启用保留章节信息 As Boolean = False
    Public Property 流控制_快速剪辑_入点 As String = ""
    Public Property 流控制_快速剪辑_出点 As String = ""
    Public Property 流控制_启用自动混流同名字幕文件 As Boolean = False
    Public Property 流控制_filter_complex As String = ""


End Class
