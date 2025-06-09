นี่คือ Python เวอร์ชัน 3.15.0 อัลฟ่า 0
=====================================

.. image:: https://github.com/python/cpython/actions/workflows/build.yml/badge.svg?branch=main&event=push
   :alt: สถานะการสร้าง CPython บน GitHub Actions
   :target: https://github.com/python/cpython/actions

.. image:: https://dev.azure.com/python/cpython/_apis/build/status/Azure%20Pipelines%20CI?branchName=main
   :alt: สถานะการสร้าง CPython บน Azure DevOps
   :target: https://dev.azure.com/python/cpython/_build/latest?definitionId=4&branchName=main

.. image:: https://img.shields.io/badge/discourse-join_chat-brightgreen.svg
   :alt: แชท Python Discourse
   :target: https://discuss.python.org/


ลิขสิทธิ์ © 2001 Python Software Foundation. สงวนลิขสิทธิ์ทุกประการ

ดูข้อมูลลิขสิทธิ์และใบอนุญาตเพิ่มเติมที่ท้ายไฟล์นี้

.. contents::

ข้อมูลทั่วไป
-------------------

- เว็บไซต์: https://www.python.org
- ซอร์สโค้ด: https://github.com/python/cpython
- ตัวติดตามปัญหา: https://github.com/python/cpython/issues
- เอกสาร: https://docs.python.org
- คู่มือสำหรับนักพัฒนา: https://devguide.python.org/

การมีส่วนร่วมใน CPython
-----------------------

สำหรับคำแนะนำที่สมบูรณ์เกี่ยวกับการมีส่วนร่วมในการพัฒนา CPython
โปรดดูที่ `Developer Guide`_

.. _Developer Guide: https://devguide.python.org/

การใช้งาน Python
----------------

ชุดติดตั้ง Python และข้อมูลเกี่ยวกับการใช้ Python สามารถดูได้ที่
`python.org`_

.. _python.org: https://www.python.org/

คำแนะนำในการสร้าง (Build Instructions)
------------------

บน Unix, Linux, BSD, macOS และ Cygwin::

    ./configure
    make
    make test
    sudo make install

คำสั่งเหล่านี้จะติดตั้ง Python เป็น ``python3``

คุณสามารถใส่ตัวเลือกเพิ่มเติมให้กับสคริปต์ configure ได้; รัน ``./configure --help``
เพื่อดูข้อมูลเพิ่มเติม ใน macOS ที่ใช้ระบบไฟล์ไม่แยกตัวพิมพ์ใหญ่-เล็ก และใน Cygwin
ไฟล์ปฏิบัติการจะชื่อ ``python.exe``; ที่อื่นจะเป็นเพียงแค่ ``python``

การสร้างการติดตั้ง Python ที่สมบูรณ์จำเป็นต้องใช้ไลบรารีของบุคคลที่สามเพิ่มเติมหลายตัว ขึ้นอยู่กับแพลตฟอร์มที่ใช้สร้างและตัวเลือกของ configure ไม่ใช่ทุกโมดูลของไลบรารีมาตรฐานจะสามารถสร้างหรือใช้งานได้บนทุกแพลตฟอร์ม ดูรายละเอียดปัจจุบันเกี่ยวกับไลบรารีที่จำเป็นสำหรับดิสทริบิวชัน Linux และ macOS ต่างๆ ได้ในหัวข้อ
`Install dependencies <https://devguide.python.org/getting-started/setup-building.html#build-dependencies>`_
ของ `Developer Guide`_

บน macOS มีตัวเลือก configure และ build เพิ่มเติมที่เกี่ยวข้องกับ framework และ universal build ของ macOS โปรดดู `Mac/README.rst
<https://github.com/python/cpython/blob/main/Mac/README.rst>`_

บน Windows ดูที่ `PCbuild/readme.txt
<https://github.com/python/cpython/blob/main/PCbuild/readme.txt>`_

หากต้องการสร้าง Windows installer ดูที่ `Tools/msi/README.txt
<https://github.com/python/cpython/blob/main/Tools/msi/README.txt>`_

หากต้องการ คุณสามารถสร้างไดเรกทอรีย่อยและเรียกใช้ configure จากที่นั่น ตัวอย่าง::

    mkdir debug
    cd debug
    ../configure --with-pydebug
    make
    make test

(จะล้มเหลวหากคุณ *ยัง* สร้างที่ไดเรกทอรีระดับบนสุด คุณควรทำ
``make clean`` ที่ไดเรกทอรีระดับบนสุดก่อน)

หากต้องการสร้าง Python ที่ปรับแต่งประสิทธิภาพ ``configure --enable-optimizations``
ก่อนจะรัน ``make`` คำสั่งนี้จะตั้งค่าเป้าหมายเริ่มต้นของ make เพื่อเปิดใช้งาน
Profile Guided Optimization (PGO) และอาจใช้เพื่อเปิดใช้งาน Link Time
Optimization (LTO) อัตโนมัติบนบางแพลตฟอร์ม รายละเอียดเพิ่มเติมดูหัวข้อด้านล่าง

Profile Guided Optimization
^^^^^^^^^^^^^^^^^^^^^^^^^^^

PGO ใช้ประโยชน์จากคอมไพเลอร์ GCC หรือ Clang เวอร์ชันล่าสุด หากใช้งาน
ไม่ว่าจะผ่าน ``configure --enable-optimizations`` หรือรัน
``make profile-opt`` ด้วยตนเองโดยไม่สนใจแฟล็กของ configure กระบวนการ build ที่ปรับแต่งจะดำเนินการดังนี้:

ไดเรกทอรี Python ทั้งหมดจะถูกล้างไฟล์ชั่วคราวที่เกิดจากการคอมไพล์ครั้งก่อน

จะมีการสร้าง interpreter เวอร์ชันที่ฝังคำสั่งโปรไฟล์ โดยใช้แฟล็กคอมไพเลอร์ที่เหมาะสมสำหรับแต่ละชนิด โปรดทราบว่านี่เป็นเพียงขั้นตอนกลาง ไบนารีที่ได้จากขั้นตอนนี้ไม่เหมาะกับการใช้งานจริง เนื่องจากฝังคำสั่งโปรไฟล์ไว้ข้างใน

หลังจากสร้าง interpreter ที่ฝังคำสั่งโปรไฟล์แล้ว Makefile จะรัน workload สำหรับฝึกฝน ซึ่งจำเป็นเพื่อโปรไฟล์การทำงานของ interpreter โปรดทราบด้วยว่าข้อมูล stdout และ stderr ใดๆ ที่อาจปรากฏในขั้นตอนนี้จะถูกระงับไว้

ขั้นตอนสุดท้ายคือสร้าง interpreter ตัวจริง โดยใช้ข้อมูลที่รวบรวมจากตัวที่ฝังคำสั่งโปรไฟล์ ผลลัพธ์สุดท้ายคือไบนารี Python ที่ปรับแต่งประสิทธิภาพ เหมาะสำหรับแจกจ่ายหรือใช้งานจริง

Link Time Optimization
^^^^^^^^^^^^^^^^^^^^^^

เปิดใช้งานผ่านแฟล็ก ``--with-lto`` ของ configure LTO ใช้ประโยชน์จากความสามารถของเครื่องมือคอมไพเลอร์ยุคใหม่ในการปรับแต่งข้ามขอบเขตไฟล์ ``.o`` เมื่อสร้าง executable หรือไลบรารีแบบ shared เพื่อเพิ่มประสิทธิภาพเพิ่มเติม

มีอะไรใหม่
----------

เรามีภาพรวมที่ครอบคลุมของการเปลี่ยนแปลงในเอกสาร `What's new in Python
3.15 <https://docs.python.org/3.15/whatsnew/3.15.html>`_ สำหรับ log การเปลี่ยนแปลงที่ละเอียดกว่า อ่านที่ `Misc/NEWS
<https://github.com/python/cpython/tree/main/Misc/NEWS.d>`_ แต่การเปลี่ยนแปลงทั้งหมดสามารถดูได้จาก `commit history
<https://github.com/python/cpython/commits/main>`_

หากคุณต้องการติดตั้ง Python หลายเวอร์ชัน ดูหัวข้อด้านล่าง
"Installing multiple versions"

เอกสาร
-------------

`เอกสารสำหรับ Python 3.15 <https://docs.python.org/3.15/>`_ มีให้ทางออนไลน์
และอัปเดตทุกวัน

คุณยังสามารถดาวน์โหลดเอกสารในหลายรูปแบบเพื่อการเข้าถึงที่รวดเร็วขึ้น เอกสารมีให้ดาวน์โหลดในรูปแบบ HTML, PDF และ reStructuredText; แบบหลังนี้เหมาะสำหรับผู้เขียนเอกสาร นักแปล และผู้ที่มีความต้องการรูปแบบพิเศษ

สำหรับข้อมูลเกี่ยวกับการสร้างเอกสารของ Python ดูที่ `Doc/README.rst
<https://github.com/python/cpython/blob/main/Doc/README.rst>`_

การทดสอบ
-------

หากต้องการทดสอบ interpreter ให้พิมพ์ ``make test`` ในไดเรกทอรีระดับบนสุด ชุดทดสอบจะสร้างเอาต์พุตบางอย่าง โดยทั่วไปคุณสามารถละเว้นข้อความเกี่ยวกับการทดสอบที่ข้ามไปเนื่องจากฟีเจอร์เสริมที่ไม่สามารถนำเข้าได้ หากมีข้อความเกี่ยวกับการทดสอบที่ล้มเหลว หรือมี traceback หรือ core dump แสดงว่ามีบางอย่างผิดปกติ

โดยปกติ การทดสอบจะถูกป้องกันไม่ให้ใช้ทรัพยากรมากเกินไป เช่น พื้นที่ดิสก์และหน่วยความจำ หากต้องการเปิดใช้งานการทดสอบเหล่านี้ ให้รัน ``make buildbottest``

หากมีการทดสอบใดล้มเหลว คุณสามารถรันการทดสอบที่ล้มเหลวซ้ำในโหมด verbose ได้ ตัวอย่างเช่น หาก ``test_os`` และ ``test_gdb`` ล้มเหลว คุณสามารถรัน::

    make test TESTOPTS="-v test_os test_gdb"

หากการล้มเหลวยังคงเกิดขึ้นและดูเหมือนว่าจะเป็นปัญหาของ Python ไม่ใช่สิ่งแวดล้อมของคุณ คุณสามารถ `แจ้งบั๊ก
<https://github.com/python/cpython/issues>`_ และแนบเอาต์พุตที่เกี่ยวข้องจากคำสั่งนั้นเพื่อแสดงปัญหา

ดู `Running & Writing Tests <https://devguide.python.org/testing/run-write-tests.html>`_
สำหรับข้อมูลเพิ่มเติมเกี่ยวกับการรันการทดสอบ

การติดตั้งหลายเวอร์ชัน
----------------------------

บนระบบ Unix และ Mac หากคุณต้องการติดตั้ง Python หลายเวอร์ชัน
โดยใช้ installation prefix เดียวกัน (อาร์กิวเมนต์ ``--prefix`` ให้กับสคริปต์ configure) คุณต้องระวังไม่ให้ไฟล์ python หลักของคุณถูกเขียนทับโดยการติดตั้งเวอร์ชันอื่น ไฟล์และไดเรกทอรีทั้งหมดที่ติดตั้งโดยใช้ ``make altinstall`` จะมีเวอร์ชัน major และ minor รวมอยู่ด้วย จึงสามารถอยู่ร่วมกันได้ ``make install`` ยังสร้าง
``${prefix}/bin/python3`` ที่อ้างถึง ``${prefix}/bin/python3.X`` หากคุณ
ต้องการติดตั้งหลายเวอร์ชันโดยใช้ prefix เดียวกัน คุณต้องตัดสินใจว่าจะให้เวอร์ชันใด (ถ้ามี) เป็นเวอร์ชัน "หลัก" ของคุณ ติดตั้งเวอร์ชันนั้นโดย
``make install``.  ติดตั้งเวอร์ชันอื่น ๆ ทั้งหมดโดยใช้ ``make altinstall``.

ตัวอย่างเช่น หากคุณต้องการติดตั้ง Python 2.7, 3.6 และ 3.15 โดยที่ 3.15 เป็นเวอร์ชันหลัก คุณจะต้องรันคำสั่ง ``make install`` ในไดเรกทอรีที่สร้าง 3.15 ของคุณ และใช้ ``make altinstall`` ในเวอร์ชันอื่น ๆ


กำหนดการออกเวอร์ชัน
----------------------

ดูรายละเอียดการออกเวอร์ชัน Python 3.15 ได้ที่ `PEP 790 <https://peps.python.org/pep-0790/>`__


ข้อมูลลิขสิทธิ์และสัญญาอนุญาต
----------------------------------


ลิขสิทธิ์ © 2001 มูลนิธิซอฟต์แวร์ไพธอน สงวนลิขสิทธิ์ทุกประการ

ลิขสิทธิ์ © 2000 BeOpen.com. สงวนลิขสิทธิ์ทุกประการ

ลิขสิทธิ์ © 1995-2001 Corporation for National Research Initiatives. สงวนลิขสิทธิ์ทุกประการ

ลิขสิทธิ์ © 1991-1995 Stichting Mathematisch Centrum. สงวนลิขสิทธิ์ทุกประการ

ดู `LICENSE <https://github.com/python/cpython/blob/main/LICENSE>`_ สำหรับข้อมูลเกี่ยวกับประวัติของซอฟต์แวร์นี้ เงื่อนไขการใช้งาน และ
ข้อสงวนสิทธิ์ของการรับประกันทั้งหมด

การแจกจ่าย Python นี้ *ไม่มี* โค้ด GNU General Public License (GPL) ดังนั้นสามารถนำไปใช้ในโครงการเชิงพาณิชย์ได้ มีอินเทอร์เฟซกับโค้ดของ GNU บางส่วนแต่ทั้งหมดเป็นตัวเลือก

เครื่องหมายการค้าทั้งหมดที่อ้างถึงในที่นี้เป็นทรัพย์สินของเจ้าของที่เกี่ยวข้อง

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---